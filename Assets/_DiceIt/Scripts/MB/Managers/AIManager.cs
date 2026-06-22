using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class AIManager : MonoBehaviour
{
    #region Nested Classes & Variables

    private class RollTargetInfo
    {
        public OffensiveAbilityData ability;
        public int tierIndex;
        public float utilityScore;
        public float expectedValue;
        public List<int> diceToLock;
        public int missingDice;
    }

    public static AIManager Instance;

    [Header("Configuration")]
    public float delayBetweenActions = 2.0f;
    [Range(0f, 1f)] public float riskFactor = 0.65f;
    private Coroutine activeAiCoroutine;

    [Header("Logging & Stats")]
    public string logFileName = "AILog.txt";
    private string fullLogPath;
    private int statCardsPlayed = 0;
    private int statAbilitiesActivated = 0;
    private int statTokensSpent = 0;
    private int statPasses = 0;

    private int currentStance = 0; // 0 = Standard, 1 = Aggressive, 2 = Defensive

    #endregion

    #region Unity Lifecycle & Events

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        
        fullLogPath = Path.Combine(Application.dataPath, logFileName);
    }

    private void Start()
    {
        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.OnPriorityChanged += HandlePriorityChanged;
        }
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnGameOver += HandleGameOver;
            BattleManager.Instance.OnPhaseChanged += HandlePhaseChanged;
        }
        
        File.AppendAllText(fullLogPath, $"\n\n========================================\n");
        File.AppendAllText(fullLogPath, $"=== NEW GAME [{DateTime.Now:dd-MM-yyyy HH:mm:ss}] ===\n");
        File.AppendAllText(fullLogPath, $"========================================\n");
    }

    private void OnDestroy()
    {
        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.OnPriorityChanged -= HandlePriorityChanged;
        }
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnGameOver -= HandleGameOver;
            BattleManager.Instance.OnPhaseChanged -= HandlePhaseChanged;
        }
    }

    private void HandlePhaseChanged(TurnPhase phase)
    {
        lastPickedDieIndex = -1;
        isSelectingSourceDie = false;

        if (phase == TurnPhase.Cleanup && BattleManager.Instance.activePlayer.isAI)
        {
            StartCoroutine(AICleanupRoutine(BattleManager.Instance.activePlayer));
        }
    }

    private void HandlePriorityChanged(PlayerController playerWithPriority)
    {
        if (playerWithPriority != null && playerWithPriority.isAI)
        {
            lastPickedDieIndex = -1;
            isSelectingSourceDie = false;

            if (activeAiCoroutine != null) StopCoroutine(activeAiCoroutine);
            activeAiCoroutine = StartCoroutine(ProcessAiTurnRoutine(playerWithPriority));
        }
    }

    #endregion
    
    #region Logging & Stats

    private void LogAI(string message)
    {
        Debug.Log(message);
        try
        {
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            File.AppendAllText(fullLogPath, $"[{timeStamp}] {message}\n");
        }
        catch (Exception e)
        {
            Debug.LogError("Failed to write to AI log: " + e.Message);
        }
    }

    private void HandleGameOver(PlayerController winner)
    {
        LogAI($"\n=== GAME OVER ===");
        LogAI($"Winner: {winner.characterData.heroName}");
        LogAI($"--- AI STATISTICS ---");
        LogAI($"Total Cards Played: {statCardsPlayed}");
        LogAI($"Total Abilities Activated: {statAbilitiesActivated}");
        LogAI($"Total Tokens Spent: {statTokensSpent}");
        LogAI($"Total Priority Passes: {statPasses}");
        LogAI($"=====================\n");
    }

    #endregion

    #region Main Loop (Turn Phase Handling)

    private double[] BuildStrategyState(PlayerController aiPlayer)
    {
        double[] state = new double[15];
        var bm = BattleManager.Instance;
        PlayerController opponent = (bm.player1 == aiPlayer) ? bm.player2 : bm.player1;

        state[0] = (bm.activePlayer == aiPlayer) ? 1.0 : 0.0; // IsMyTurn
        
        // Normalized HP and CP (ratios between 0 and 1)
        float myMaxHP = aiPlayer.characterData != null ? aiPlayer.characterData.maxHealth : 50f;
        float oppMaxHP = opponent.characterData != null ? opponent.characterData.maxHealth : 50f;
        float myMaxCP = aiPlayer.characterData != null ? aiPlayer.characterData.maxCombatPoints : 15f;
        float oppMaxCP = opponent.characterData != null ? opponent.characterData.maxCombatPoints : 15f;

        state[1] = myMaxHP > 0 ? (float)aiPlayer.currentHealth / myMaxHP : 0f;
        state[2] = myMaxCP > 0 ? (float)aiPlayer.currentCombatPoints / myMaxCP : 0f;
        state[3] = oppMaxHP > 0 ? (float)opponent.currentHealth / oppMaxHP : 0f;
        state[4] = oppMaxCP > 0 ? (float)opponent.currentCombatPoints / oppMaxCP : 0f;

        // Token counts (sums of stacks)
        state[5] = aiPlayer.activeStatuses.Where(s => s.data.type == StatusType.Positive).Sum(s => s.currentStacks);
        state[6] = aiPlayer.activeStatuses.Where(s => s.data.type == StatusType.Negative).Sum(s => s.currentStacks);
        state[7] = opponent.activeStatuses.Where(s => s.data.type == StatusType.Positive).Sum(s => s.currentStacks);
        state[8] = opponent.activeStatuses.Where(s => s.data.type == StatusType.Negative).Sum(s => s.currentStacks);

        // Context
        state[9] = DiceManager.Instance != null ? DiceManager.Instance.rollsLeft : 0;
        state[10] = aiPlayer.hand.Count;
        state[11] = opponent.hand.Count;
        state[12] = (int)bm.currentPhase; // Raw enum index

        // Differences
        state[13] = state[1] - state[3]; // PlayerHP Ratio - OpponentHP Ratio
        state[14] = state[2] - state[4]; // PlayerCP Ratio - OpponentCP Ratio

        return state;
    }

    private void UpdateActiveStance(PlayerController aiPlayer)
    {
        try
        {
            double[] state = BuildStrategyState(aiPlayer);
            double[] scores = ML.RFBrain.Score(state);

            int bestStance = 0;
            double maxScore = scores[0];
            if (scores[1] > maxScore)
            {
                maxScore = scores[1];
                bestStance = 1;
            }
            if (scores[2] > maxScore)
            {
                maxScore = scores[2];
                bestStance = 2;
            }

            if (currentStance != bestStance)
            {
                LogAI($"[AIManager] Strategic stance changed from {GetStanceName(currentStance)} to {GetStanceName(bestStance)} (Scores - Std: {scores[0]:F3}, Agg: {scores[1]:F3}, Def: {scores[2]:F3})");
                currentStance = bestStance;
            }
        }
        catch (Exception e)
        {
            Debug.LogError($"[AIManager] Error evaluating strategic stance: {e.Message}");
            currentStance = 0; // fallback to Standard on error
        }
    }

    private string GetStanceName(int stance)
    {
        switch (stance)
        {
            case 1: return "Aggressive";
            case 2: return "Defensive";
            default: return "Standard";
        }
    }

    private IEnumerator ProcessAiTurnRoutine(PlayerController aiPlayer)
    {
        yield return new WaitForSeconds(delayBetweenActions);

        // fallback: AI lost priority if I force skip
        if (ActionStackManager.Instance.playerWithPriority != aiPlayer)
        {
            yield break;
        }

        UpdateActiveStance(aiPlayer);

        var currentPhase = BattleManager.Instance.currentPhase;

        switch (currentPhase)
        {
            case TurnPhase.MainPhase1:
            case TurnPhase.MainPhase2:
                LogAI($"[AIManager] AI has priority in {currentPhase}. Deciding what to do...");
                
                if (TryPlayCard(aiPlayer)) yield break; 
                if (TrySellCard(aiPlayer)) 
                {
                    yield return new WaitForSeconds(delayBetweenActions / 2f);
                    StartCoroutine(ProcessAiTurnRoutine(aiPlayer));
                    yield break; 
                }
                
                LogAI($"[AIManager] No valid cards to play in {currentPhase}. Passing priority.");
                statPasses++;
                ActionStackManager.Instance.PassPriority(true);
                break;

            case TurnPhase.OffensiveRollPhase:
                LogAI($"[AIManager] AI has priority in {currentPhase}. Deciding what to do...");

                if (BattleManager.Instance.activePlayer == aiPlayer)
                {
                    // perform the mandatory initial roll (mandatory)
                    if (DiceManager.Instance != null && !DiceManager.Instance.hasRolledThisPhase)
                    {
                        LogAI("[AIManager] Performing mandatory initial roll for the phase.");
                        DiceManager.Instance.RollDice();
                        yield return new WaitForSeconds(delayBetweenActions);
                        if (ActionStackManager.Instance.playerWithPriority != aiPlayer) yield break;
                    }

                    // decide the next move (Card, Token, Reroll, Activate, or Pass).
                    if (TryPlayCard(aiPlayer)) yield break;
                    if (TrySpendToken(aiPlayer)) yield break;

                    // SMART REROLL LOOP
                    while (DiceManager.Instance != null && !BattleManager.Instance.hasActivatedAbilityThisPhase && DiceManager.Instance.rollsLeft > 0)
                    {
                        var currentDice = DiceManager.Instance.GetCurrentDiceValues();
                        var bestTarget = DetermineBestRollTarget(aiPlayer, currentDice);

                        // a "target" that's worth the risk
                        if (bestTarget != null && bestTarget.missingDice > 0 && bestTarget.expectedValue > 5f)
                        {
                            LogAI($"[AIManager] Smart Reroll: Targeting {bestTarget.ability.abilityName} (Tier {bestTarget.tierIndex}). EV: {bestTarget.expectedValue:F1}. Missing: {bestTarget.missingDice} dice.");
                            
                            // lock the best ones
                            for (int i = 0; i < DiceManager.Instance.dice.Count; i++)
                            {
                                if (!DiceManager.Instance.dice[i].isActive) continue;

                                bool shouldLock = bestTarget.diceToLock.Contains(i);
                                if (DiceManager.Instance.dice[i].isLocked != shouldLock)
                                {
                                    DiceManager.Instance.OnDieClicked(i, aiPlayer);
                                    yield return new WaitForSeconds(0.5f);
                                }
                            }

                            yield return new WaitForSeconds(0.5f);

                            LogAI($"[AIManager] AI is rerolling the remaining {5 - bestTarget.diceToLock.Count} dice.");
                            DiceManager.Instance.RollDice();
                            yield return new WaitForSeconds(delayBetweenActions);
                            if (ActionStackManager.Instance.playerWithPriority != aiPlayer) yield break;
                        }
                        else
                        {
                            // nothing to risk for
                            if (bestTarget != null && bestTarget.missingDice == 0) LogAI($"[AIManager] Reached a solid target: {bestTarget.ability.abilityName}. Stopping rerolls.");
                            else LogAI($"[AIManager] No good reroll targets found. Stopping rerolls.");
                            break;
                        }
                    }

                    // try to activate the best Offensive Ability permitted
                    if (!BattleManager.Instance.hasActivatedAbilityThisPhase)
                    {
                        yield return new WaitForSeconds(delayBetweenActions);
                        if (TryActivateOffensiveAbility(aiPlayer)) yield break;
                    }
                }

                LogAI($"[AIManager] No more actions for AI in {currentPhase}. Passing priority.");
                statPasses++;
                ActionStackManager.Instance.PassPriority(true);
                break;
                
            case TurnPhase.DefensiveRollPhase:
                LogAI("[AIManager] AI has priority in Defensive Roll Phase. Deciding what to do...");
                
                if (TryPlayCard(aiPlayer)) yield break;
                if (TrySpendToken(aiPlayer)) yield break;

                if (BattleManager.Instance.opponentPlayer == aiPlayer)
                {
                    if (BattleManager.Instance.needsDefenseSelection && aiPlayer.activeDefensiveAbilities.Count > 0)
                    {
                        // pick first for now
                        var defAbility = aiPlayer.activeDefensiveAbilities[0];
                        BattleManager.Instance.SelectDefense(defAbility);
                        yield return new WaitForSeconds(delayBetweenActions);
                    }

                    // perform the initial roll (mandatory))
                    if (DiceManager.Instance != null && !DiceManager.Instance.hasRolledThisPhase && BattleManager.Instance.pendingDefenseSelection != null)
                    {
                        LogAI("[AIManager] Performing mandatory defensive roll for the phase.");
                        DiceManager.Instance.RollDice();
                        yield return new WaitForSeconds(delayBetweenActions);
                        if (ActionStackManager.Instance.playerWithPriority != aiPlayer) yield break;
                    }

                    if (!BattleManager.Instance.hasActivatedAbilityThisPhase && BattleManager.Instance.pendingDefenseSelection != null)
                    {
                        yield return new WaitForSeconds(delayBetweenActions);
                        
                        LogAI($"[AIManager] AI activates defense: {BattleManager.Instance.pendingDefenseSelection.abilityName}");
                        BattleManager.Instance.SetPendingDefensiveAbility(BattleManager.Instance.pendingDefenseSelection);
                        BattleManager.Instance.MarkAbilityActivated();
                        yield break;
                    }
                }
                
                LogAI("[AIManager] Passing priority.");
                statPasses++;
                ActionStackManager.Instance.PassPriority(true);
                break;
        }
    }

    #endregion

    #region Cleanup (Discarding Phase)

    private IEnumerator AICleanupRoutine(PlayerController aiPlayer)
    {
        yield return new WaitForSeconds(delayBetweenActions / 2f);

        while (aiPlayer.hand.Count > 6)
        {
            var worstCard = aiPlayer.hand.OrderBy(c => EvaluateCardKeepValue(c, aiPlayer)).First();
            LogAI($"[AIManager] AI is over limit (Cleanup). Discarding worst card: {worstCard.cardName}");
            aiPlayer.DiscardCard(worstCard);
            yield return new WaitForSeconds(1.0f);
        }
    }

    #endregion

    #region Action Makers (The "Hands")

    private bool TryPlayCard(PlayerController aiPlayer)
    {
        List<CardData> playableCards = GetPlayableCards(aiPlayer);

        if (playableCards.Count > 0)
        {
            CardData bestCard = null;
            float bestScore = -9999f;

            foreach (var card in playableCards)
            {
                float score = EvaluateCardUtility(card, aiPlayer);
                LogAI($"[Utility AI] Evaluated {card.cardName} with score: {score}");
                
                if (score > bestScore)
                {
                    bestScore = score;
                    bestCard = card;
                }
            }
            
            if (bestCard != null && bestScore > 0f)
            {
                LogAI($"[AIManager] AI decided to play: {bestCard.cardName} (Score: {bestScore})");
                statCardsPlayed++;
                CardResolver.Instance.PlayCard(bestCard, aiPlayer);
                return true;
            }
        }

        return false;
    }

    private bool TrySellCard(PlayerController aiPlayer)
    {
        if (BattleManager.Instance.activePlayer != aiPlayer) return false;
        if (aiPlayer.currentCombatPoints >= aiPlayer.characterData.maxCombatPoints) return false; // Suntem Full CP
        if (aiPlayer.hand.Count == 0) return false;

        // sorting based on KeepValue
        var cardsWithKeepValue = aiPlayer.hand.Select(c => new { Card = c, KeepVal = EvaluateCardKeepValue(c, aiPlayer) })
                                              .OrderBy(x => x.KeepVal).ToList();

        // instant sell for useless cards
        var uselessCard = cardsWithKeepValue.FirstOrDefault(x => x.KeepVal < 0);
        if (uselessCard != null)
        {
            LogAI($"[AIManager] AI sells entirely useless card for 1 CP: {uselessCard.Card.cardName}");
            CardResolver.Instance.SellCard(uselessCard.Card, aiPlayer);
            return true;
        }

        // tradeoff between a mid card and a very good one
        var bestUnaffordableCard = aiPlayer.hand
            .Where(c => c.cpCost > aiPlayer.currentCombatPoints && (c.playPhase == CardPlayPhase.MainPhase || c.playPhase == CardPlayPhase.Instant || c.playPhase == CardPlayPhase.RollPhase))
            .Select(c => new { Card = c, PlayUtil = EvaluateCardUtility(c, aiPlayer) })
            .OrderByDescending(x => x.PlayUtil)
            .FirstOrDefault();

        if (bestUnaffordableCard != null && bestUnaffordableCard.PlayUtil > 25f)
        {
            var worstCard = cardsWithKeepValue.First();
            if (worstCard.Card != bestUnaffordableCard.Card && worstCard.KeepVal < 40f) // dont sell a very valuable card
            {
                LogAI($"[AIManager] AI sells '{worstCard.Card.cardName}' (KeepVal: {worstCard.KeepVal}) to save CP for '{bestUnaffordableCard.Card.cardName}' (PlayUtil: {bestUnaffordableCard.PlayUtil})");
                CardResolver.Instance.SellCard(worstCard.Card, aiPlayer);
                return true;
            }
        }

        return false;
    }

    private bool TrySpendToken(PlayerController aiPlayer)
    {
        StatusEffectsData bestToken = null;
        float bestScore = (aiPlayer.currentHealth <= 15) ? 5f : 15f;

        foreach (var status in aiPlayer.activeStatuses)
        {
            if (!status.data.isSpendable) continue;
            if (!aiPlayer.CanSpendStatus(status.data)) continue;

            float score = EvaluateTokenSpendUtility(status.data, aiPlayer);
            LogAI($"[Utility AI] Evaluated Spending Token '{status.data.effectName}' with score: {score}");

            if (score > bestScore)
            {
                bestScore = score;
                bestToken = status.data;
            }
        }

        if (bestToken != null)
        {
            LogAI($"[AIManager] AI decided to spend token: {bestToken.effectName} (Score: {bestScore})");
            statTokensSpent++;
            aiPlayer.SpendStatus(bestToken);
            return true;
        }

        return false;
    }

    private bool TryActivateOffensiveAbility(PlayerController aiPlayer)
    {
        var currentDice = DiceManager.Instance.GetCurrentDiceValues();
        
        OffensiveAbilityData bestAbility = null;
        int bestTierIndex = -1;
        float bestScore = -999f;

        List<OffensiveAbilityData> allOffensiveAbilities = new List<OffensiveAbilityData>(aiPlayer.activeOffensiveAbilities);
        if (aiPlayer.activeUltimate is OffensiveAbilityData ultimate && ultimate != null)
        {
            allOffensiveAbilities.Add(ultimate);
        }

        foreach (var ability in allOffensiveAbilities)
        {
            var validTiers = AbilityMatcher.GetValidActivations(ability, currentDice, aiPlayer.characterData.diceKey);
            foreach (int tierIndex in validTiers)
            {
                float score = EvaluateActivationUtility(ability.activations[tierIndex], aiPlayer);
                if (score > bestScore)
                {
                    bestScore = score;
                    bestTierIndex = tierIndex;
                    bestAbility = ability;
                }
            }
        }

        if (bestAbility != null)
        {
            LogAI($"[AIManager] AI activates {bestAbility.abilityName} at Tier {bestTierIndex}.");
            statAbilitiesActivated++;
            BattleManager.Instance.SetPendingOffensiveAbility(bestAbility, bestTierIndex);
            BattleManager.Instance.MarkAbilityActivated();
            
            return true;
        }

        return false;
    }

    #endregion

    #region Evaluators & Utility (The "Brain")

    private List<CardData> GetPlayableCards(PlayerController aiPlayer)
    {
        List<CardData> validCards = new List<CardData>();
        TurnPhase currentPhase = BattleManager.Instance.currentPhase;
        bool isMainPhase = (currentPhase == TurnPhase.MainPhase1 || currentPhase == TurnPhase.MainPhase2);
        bool isRollPhase = (currentPhase == TurnPhase.OffensiveRollPhase || currentPhase == TurnPhase.DefensiveRollPhase);

        foreach (var card in aiPlayer.hand)
        {
            if (!aiPlayer.CanAffordToPlayCard(card)) continue;

            bool phaseMatch = false;
            bool isMyTurn = (BattleManager.Instance.activePlayer == aiPlayer);
            
            if (card.playPhase == CardPlayPhase.MainPhase && isMainPhase && isMyTurn) phaseMatch = true;
            else if (card.playPhase == CardPlayPhase.RollPhase && isRollPhase) phaseMatch = true;
            else if (card.playPhase == CardPlayPhase.Instant) phaseMatch = true;

            if (!phaseMatch) continue;

            // check conditions
            bool conditionsMet = true;
            if (card.cardEffects != null)
            {
                foreach (var effect in card.cardEffects)
                {
                    if (effect.condition == CardConditionType.OnOffensiveRoll && currentPhase != TurnPhase.OffensiveRollPhase) conditionsMet = false;
                    if (effect.condition == CardConditionType.OnDefensiveRoll && currentPhase != TurnPhase.DefensiveRollPhase) conditionsMet = false;
                    if (effect.condition == CardConditionType.WhenAttacked && 
                                            (currentPhase != TurnPhase.DefensiveRollPhase 
                                            || BattleManager.Instance.opponentPlayer != aiPlayer 
                                            || BattleManager.Instance.committedOffense == null)) conditionsMet = false;

                    if (effect.condition == CardConditionType.DiscardStatus)
                    {
                        StatusEffectsData reqStatus = effect.statusRequirement != null ? effect.statusRequirement : (effect.statuses?.Count > 0 ? effect.statuses[0].status : null);
                        if (reqStatus != null)
                        {
                            var existing = aiPlayer.activeStatuses.FirstOrDefault(s => s.data == reqStatus);
                            int cost = effect.discardAmount > 0 ? effect.discardAmount : 1;

                            if (existing == null || existing.currentStacks < cost) conditionsMet = false;   
                        }
                        else
                        {
                            conditionsMet = false;
                        }
                    }
                    
                    if (effect.condition == CardConditionType.StatusStacksScaling)
                    {
                        if (effect.statusRequirement != null)
                        {
                            var existing = aiPlayer.activeStatuses.FirstOrDefault(s => s.data == effect.statusRequirement);
                            if (existing == null || existing.currentStacks <= 0) conditionsMet = false;
                        }
                    }
                }
            }

            if (conditionsMet) validCards.Add(card);
        }

        return validCards;
    }

    private float EvaluateCardKeepValue(CardData card, PlayerController aiPlayer)
    {
        float score = 10f + (card.cpCost * 5f); // Base score: more expensive card are generally better

        if (card.cardType == CardType.Upgrade)
        {
            score += 40f;
        }

        if (card.cardEffects != null)
        {
            foreach (var effect in card.cardEffects)
            {
                switch (effect.actionType)
                {
                    case CardActionType.AddRollAttempt:
                    case CardActionType.ChangeDiceValue:
                    case CardActionType.ChangeDiceValueToSix:
                    case CardActionType.RerollDice:
                        score += 30f; break;

                    case CardActionType.DrawCard:
                    case CardActionType.GainCP:
                        score += 20f; break;

                    case CardActionType.MakeAttackUndefendable:
                    case CardActionType.PreventDamage:
                        score += 25f; break;

                    default:
                        score += 15f; break; 
                }
            }
        }
        
        return score;
    }

    private float EvaluateCardUtility(CardData card, PlayerController aiPlayer)
    {
        float score = 0f;
        var bm = BattleManager.Instance;
        PlayerController opponent = bm.opponentPlayer == aiPlayer ? bm.activePlayer : bm.opponentPlayer;
        PlayerController rollingPlayer = (bm.currentPhase == TurnPhase.DefensiveRollPhase) ? bm.opponentPlayer : bm.activePlayer;

        // CP BUDGETING (keeping CP for Roll Phase)
        if (card.playPhase == CardPlayPhase.MainPhase && card.cpCost > 0)
        {
            // Bugetăm agresiv doar în MainPhase1. În MainPhase2 putem cheltui CP-ul rămas!
            if (bm.currentPhase == TurnPhase.MainPhase1)
            {
                float maxRollPhaseCostInHand = aiPlayer.hand
                    .Where(c => c.playPhase == CardPlayPhase.RollPhase || c.playPhase == CardPlayPhase.Instant)
                    .Max(c => (float?)c.cpCost) ?? 0f;

                if (aiPlayer.currentCombatPoints - card.cpCost < maxRollPhaseCostInHand)
                {
                    score -= 50f; 
                }
            }
        }

        // UPGRADES
        if (card.cardType == CardType.Upgrade)
        {
            score += 20f + (aiPlayer.currentCombatPoints * 5f);
            if (aiPlayer.hand.Count <= 3) score += 20f;
        }

        if (card.cardEffects != null)
        {
            foreach (var effect in card.cardEffects)
            {
                float effectValue = effect.value;
                if (effect.isScaling) effectValue *= 1.5f;

                switch (effect.actionType)
                {
                    // ECONOMY
                    case CardActionType.GainCP:
                        int missingCP = aiPlayer.characterData.maxCombatPoints - aiPlayer.currentCombatPoints;
                        if (missingCP <= 0) score -= 1000f;
                        else score += Mathf.Min(effectValue, missingCP) * 20f;
                        break;

                    case CardActionType.DrawCard:
                        int handSpace = 6 - aiPlayer.hand.Count;
                        if (handSpace <= 0) score -= 100f;
                        else score += effectValue * 15f + (handSpace * 5f);
                        break;

                    // SURVIVAL
                    case CardActionType.Heal:
                        float missingHP = aiPlayer.characterData.maxHealth - aiPlayer.currentHealth;
                        float healVal = 0f;
                        if (missingHP <= 0) healVal -= 1000f;
                        else healVal += Mathf.Min(effectValue, missingHP) * 3f;
                        
                        if (aiPlayer.currentHealth < 10) healVal += 50f;
                        
                        if (currentStance == 2) healVal *= 2.0f; // defensive stance scaling
                        score += healVal;
                        break;
                        
                    case CardActionType.PreventDamage:
                        if (bm.currentPhase != TurnPhase.DefensiveRollPhase) break;
                        if (bm.opponentPlayer != aiPlayer || bm.turnAttackUndefendable)
                        {
                            score -= 1000f;
                            break;
                        }
                        
                        float incomingDmg = bm.committedOffense != null ? 10f : 0f;
                        float currentPrevention = (bm.player1 == aiPlayer) ? bm.p1DamagePrevention : bm.p2DamagePrevention;
                        float unpreventedDmg = incomingDmg - currentPrevention;
                        
                        float preventVal = 0f;
                        if (unpreventedDmg <= 0) preventVal -= 100f;
                        else preventVal += Mathf.Min(effectValue, unpreventedDmg) * 5f;
                        
                        if (currentStance == 2) preventVal *= 2.0f; // defensive stance scaling
                        score += preventVal;
                        break;

                    // OFFENSE
                    case CardActionType.Damage:
                        float dmgVal = 0f;
                        if (opponent.currentHealth <= effectValue) dmgVal += 1000f;
                        else dmgVal += effectValue * 2f;
                        
                        if (currentStance == 1) dmgVal *= 1.5f; // aggressive stance scaling
                        score += dmgVal;
                        break;

                    case CardActionType.MakeAttackUndefendable:
                        if (bm.currentPhase != TurnPhase.OffensiveRollPhase) break;
                        if (rollingPlayer != aiPlayer) { score -= 1000f; break; }
                        
                        // good value for a pending Ult
                        // TODO: not only ultimate can be valuable, other abilities that give you a good Status Effect or deals a lot of damage should also be "praised"
                        if (bm.pendingOffensiveAbility == aiPlayer.activeUltimate) score += 150f;
                        else if (bm.pendingOffensiveAbility != null) score += 40f;
                        else score -= 100f;
                        break;

                    // STATUS EFFECTS
                    case CardActionType.GainStatus:
                        if (effect.statuses != null)
                        {
                            foreach (var statusApp in effect.statuses)
                            {
                                PlayerController targetPlayer = effect.targetMode == CardTargetMode.Opponent ? opponent : aiPlayer;
                                StatusEffectsData statusToGain = statusApp.status;
                                
                                bool limitReached = false;
                                if (statusToGain.maxGlobalTokens > 0)
                                {
                                    int p1Stacks = bm.player1.activeStatuses.FirstOrDefault(s => s.data == statusToGain)?.currentStacks ?? 0;
                                    int p2Stacks = bm.player2.activeStatuses.FirstOrDefault(s => s.data == statusToGain)?.currentStacks ?? 0;
                                    if (p1Stacks + p2Stacks >= statusToGain.maxGlobalTokens) limitReached = true;
                                }
                                var existing = targetPlayer.activeStatuses.FirstOrDefault(s => s.data == statusToGain);
                                if (existing != null && existing.currentStacks >= statusToGain.stackLimit) limitReached = true;

                                if (limitReached) 
                                {
                                    score -= 1000f;
                                }
                                else
                                {
                                    float expectedAmount = effect.isScaling ? effectValue * 1.5f : statusApp.amount;
                                    if (statusToGain.type == StatusType.Positive && targetPlayer == aiPlayer)
                                    {
                                        float val = expectedAmount * 30f;
                                        if (currentStance == 1) val *= 1.5f; // aggressive stance self buff scaling
                                        score += val;
                                    }
                                    if (statusToGain.type == StatusType.Negative && targetPlayer == opponent)
                                    {
                                        float val = expectedAmount * 30f;
                                        if (currentStance == 1) val *= 1.5f; // aggressive stance opponent debuff scaling
                                        score += val;
                                    }
                                    if (statusToGain.type == StatusType.Negative && targetPlayer == aiPlayer) score -= 1000f;
                                    if (statusToGain.type == StatusType.Positive && targetPlayer == opponent) score -= 1000f;
                                }
                            }
                        }
                        break;

                    case CardActionType.RemoveStatus:
                        if (opponent.activeStatuses.Any(s => s.data.type == StatusType.Positive))
                        {
                            score += 80f;
                        }
                        if (aiPlayer.activeStatuses.Any(s => s.data.type == StatusType.Negative))
                        {
                            score += 80f;
                        }
                        break;

                    case CardActionType.AddRollAttempt:
                        if (bm.currentPhase == TurnPhase.OffensiveRollPhase || bm.currentPhase == TurnPhase.DefensiveRollPhase)
                        {
                            if (bm.currentPhase == TurnPhase.DefensiveRollPhase && !bm.canActivateDefensiveAbility)
                            {
                                score -= 1000f;
                                break;
                            }
                            if (rollingPlayer == aiPlayer) score += effectValue * 15f;
                            else score -= 1000f;
                        }
                        break;

                    // DICE DISRUPTION
                    case CardActionType.ForceOpponentReroll:
                    case CardActionType.ChangeDiceValueIdenticalToAnother:
                    case CardActionType.ChangeDiceValue:
                    case CardActionType.ChangeDiceValueToSix:
                    case CardActionType.RerollDice:
                    case CardActionType.IncrementOrDecrement:
                        if (bm.currentPhase == TurnPhase.DefensiveRollPhase && !bm.canActivateDefensiveAbility)
                        {
                            score -= 1000f;
                            break;
                        }

                        if (DiceManager.Instance != null && DiceManager.Instance.hasRolledThisPhase)
                        {
                            if (effect.targetMode == CardTargetMode.Self && rollingPlayer == aiPlayer) 
                            {
                                if (bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.pendingDefenseSelection != null)
                                {
                                    bool alreadyMet = false;
                                    var diceVals = DiceManager.Instance.GetCurrentDiceValues();
                                    if (AbilityResolver.Instance != null)
                                    {
                                        foreach (var outc in bm.pendingDefenseSelection.primaryDefensiveOutcomes)
                                        {
                                            if (AbilityResolver.Instance.IsConditionMet(outc, diceVals, aiPlayer.characterData.diceKey, out _))
                                            {
                                                alreadyMet = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (alreadyMet) score -= 1000f;
                                    else score += (DiceManager.Instance.rollsLeft > 0) ? 10f : 40f;
                                }
                                else 
                                {
                                    score += 40f;
                                }
                            }
                            else if (effect.targetMode == CardTargetMode.Opponent && rollingPlayer == opponent) score += 45f;
                            else if (effect.targetMode == CardTargetMode.ChosenPlayer) score += 45f;
                            else score -= 1000f;
                        }
                        else score -= 1000f;
                        break;
                }
            }
        }
        
        // SECONDARY ROLLS
        if (card.cardRolls != null && card.cardRolls.Count > 0)
        {
            foreach (var secRoll in card.cardRolls)
            {
                foreach (var outcome in secRoll.outcomes)
                {
                    float expectedRollValue = outcome.isScaling ? outcome.value * 3.5f : outcome.value;

                    switch (outcome.type)
                    {
                        case AbilityOutcomeType.GainCP:
                            int missingCP = aiPlayer.characterData.maxCombatPoints - aiPlayer.currentCombatPoints;
                            if (missingCP > 0) score += Mathf.Min(expectedRollValue, missingCP) * 20f;
                            break;
                        case AbilityOutcomeType.Healing:
                            float missingHP = aiPlayer.characterData.maxHealth - aiPlayer.currentHealth;
                            if (missingHP > 0) score += Mathf.Min(expectedRollValue, missingHP) * 3f;
                            break;
                        case AbilityOutcomeType.Damage:
                            if (opponent.currentHealth <= expectedRollValue) score += 1000f;
                            else score += expectedRollValue * 2f;
                            break;
                    }

                    // adding statuses
                    if (outcome.statuses != null)
                    {
                        foreach (var status in outcome.statuses)
                        {
                            float expectedAmount = outcome.isScaling ? expectedRollValue : status.amount;
                            if (status.status.type == StatusType.Positive && outcome.target == StatusTarget.Self) score += expectedAmount * 15f;
                            if (status.status.type == StatusType.Negative && outcome.target == StatusTarget.Opponent) score += expectedAmount * 15f;
                        }
                    }
                }
            }
        }

        // expensive card must REALLY be valuable
        score -= card.cpCost * 20f;

        return score;
    }

    private float EvaluateTokenSpendUtility(StatusEffectsData tokenData, PlayerController aiPlayer)
    {
        float score = 0f;
        var bm = BattleManager.Instance;
        PlayerController opponent = bm.opponentPlayer == aiPlayer ? bm.activePlayer : bm.opponentPlayer;

        // 1. direct utility (manual spending)
        if (tokenData.primaryStatusEffectOutcomes != null)
        {
            foreach (var outcome in tokenData.primaryStatusEffectOutcomes)
            {
                if (outcome.activationTrigger == StatusTrigger.OnManualSpend)
                {
                    switch (outcome.type)
                    {
                        case StatusOutcomeType.Prevent:
                            if (bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.committedOffense != null) score += outcome.value * 8f; 
                            break;
                            
                        case StatusOutcomeType.TakeBonusORP:
                            score += 65f;
                            break;

                        case StatusOutcomeType.ChangeAttackType:
                            // defensive use: Undefendable -> Defendable
                            if (bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.opponentPlayer == aiPlayer) 
                            {
                                if (bm.committedOffense != null && bm.committedOffense.runtimeAttackType == DamageType.Undefendable) score += 80f;
                            }
                            // offensive use: Defendable -> Undefendable
                            else if (bm.currentPhase == TurnPhase.OffensiveRollPhase && bm.activePlayer == aiPlayer)
                            {
                                if (bm.pendingOffensiveAbility != null) score += 60f;
                            }
                            break;
                            
                        case StatusOutcomeType.Damage:
                            if (opponent.currentHealth <= outcome.value) score += 1000f;
                            else score += outcome.value * 4f;
                            break;
                            
                        case StatusOutcomeType.Healing:
                            float missingHP = aiPlayer.characterData.maxHealth - aiPlayer.currentHealth;
                            if (missingHP > 0) score += Mathf.Min(outcome.value, missingHP) * 5f;
                            break;
                            
                        case StatusOutcomeType.GainCP:
                            int missingCP = aiPlayer.characterData.maxCombatPoints - aiPlayer.currentCombatPoints;
                            if (missingCP > 0) score += Mathf.Min(outcome.value, missingCP) * 10f;
                            break;
                            
                        case StatusOutcomeType.DrawCard:
                            int handSpace = 6 - aiPlayer.hand.Count;
                            if (handSpace > 0) score += Mathf.Min(outcome.value, handSpace) * 10f;
                            break;
                    }
                }
            }
        }

        // fallback: spending Invisibility for extra Defense Rolls 
        if (bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.pendingDefenseSelection != null)
        {
             foreach (var outcome in bm.pendingDefenseSelection.primaryDefensiveOutcomes)
             {
                 if (outcome.type == AbilityOutcomeType.ModifyRollAttempts && outcome.statuses != null)
                 {
                     if (outcome.statuses.Any(s => s.status == tokenData && s.amount < 0))
                     {
                         score += 45f;
                     }
                 }
             }
        }

        // 2. card utility (keep tokens for card effects)
        float maxCardUtilityRequiringToken = 0f;
        foreach (var card in aiPlayer.hand)
        {
            if (card.cardEffects != null)
            {
                foreach (var effect in card.cardEffects)
                {
                    if (effect.condition == CardConditionType.DiscardStatus)
                    {
                        StatusEffectsData reqStatus = effect.statusRequirement != null ? effect.statusRequirement : (effect.statuses?.Count > 0 ? effect.statuses[0].status : null);
                        if (reqStatus == tokenData)
                        {
                            float cardUtil = EvaluateCardUtility(card, aiPlayer);
                            if (cardUtil > maxCardUtilityRequiringToken) maxCardUtilityRequiringToken = cardUtil;
                        }
                    }
                }
            }
        }

        if (maxCardUtilityRequiringToken > 30f)
        {
            score -= maxCardUtilityRequiringToken * 0.8f; 
        }

        if (currentStance == 2 && (tokenData.effectName == "Invisibility" || tokenData.effectName == "Vibranium Suit"))
        {
            score *= 2.0f;
        }
        else if (currentStance == 1 && (tokenData.effectName == "Combo" || tokenData.effectName == "Kinetic Energy" || tokenData.effectName == "Webbed"))
        {
            score *= 1.5f;
        }

        return score;
    }

    private float EvaluateActivationUtility(OffensiveAbilityData.AttackActivation activation, PlayerController aiPlayer)
    {
        float score = 0f;
        var bm = BattleManager.Instance;
        PlayerController opponent = bm.opponentPlayer == aiPlayer ? bm.activePlayer : bm.opponentPlayer;

        foreach (var outcome in activation.primaryOffensiveOutcomes)
        {
            float val = outcome.value;
            if (outcome.isScaling) val *= 1.5f;

            switch (outcome.type)
            {
                case AbilityOutcomeType.Damage:
                    if (opponent.currentHealth <= val) score += 1000f;
                    else score += val * 3f;
                    break;
                case AbilityOutcomeType.Healing:
                    float missingHP = aiPlayer.characterData.maxHealth - aiPlayer.currentHealth;
                    score += Mathf.Min(val, missingHP) * 3f;
                    break;
                case AbilityOutcomeType.GainCP:
                    score += val * 10f;
                    break;
                case AbilityOutcomeType.AttackModifier:
                    score += val * 2.5f;
                    break;
                case AbilityOutcomeType.DrawCard:
                    int handSpace = 6 - aiPlayer.hand.Count;
                    if (handSpace > 0) score += Mathf.Min(val, handSpace) * 10f;
                    break;
            }

            if (outcome.statuses != null)
            {
                foreach (var status in outcome.statuses)
                {
                    if (status.status.type == StatusType.Positive && outcome.target == StatusTarget.Self) score += 25f;
                    if (status.status.type == StatusType.Negative && outcome.target == StatusTarget.Opponent) score += 25f;
                }
            }
        }

        // Secondary Rolls
        if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
        {
            foreach (var secRoll in activation.secondaryRolls)
            {
                foreach (var outcome in secRoll.outcomes)
                {
                    switch (outcome.type)
                    {
                        case AbilityOutcomeType.Damage:
                        case AbilityOutcomeType.AttackModifier:
                            score += outcome.value * 1.5f;
                            break;
                        case AbilityOutcomeType.Healing:
                            float missingHP = aiPlayer.characterData.maxHealth - aiPlayer.currentHealth;
                            score += Mathf.Min(outcome.value, missingHP) * 1.5f;
                            break;
                        case AbilityOutcomeType.GainCP:
                            score += outcome.value * 5f;
                            break;
                        case AbilityOutcomeType.DrawCard:
                            score += outcome.value * 5f;
                            break;
                    }

                    if (outcome.statuses != null)
                    {
                        foreach (var status in outcome.statuses)
                        {
                            if (status.status.type == StatusType.Positive && outcome.target == StatusTarget.Self) score += 12.5f; // Baza era 25f
                            if (status.status.type == StatusType.Negative && outcome.target == StatusTarget.Opponent) score += 12.5f;
                        }
                    }
                }
            }
        }

        if (currentStance == 1)
        {
            score *= 1.5f;
        }

        return score;
    }

    #endregion

    #region Smart Reroll Logic (Probabilities & EV)

    private RollTargetInfo DetermineBestRollTarget(PlayerController aiPlayer, List<int> currentDice, bool suppressLog = false)
    {
        RollTargetInfo bestTarget = null;
        float highestEV = -999f;

        System.Text.StringBuilder evLog = new System.Text.StringBuilder();
        int currentRollsLeft = DiceManager.Instance != null ? DiceManager.Instance.rollsLeft : 1;
        
        if (!suppressLog) evLog.AppendLine($"[Smart Reroll] --- EV Calculations Summary (Rolls Left: {currentRollsLeft}) ---");

        List<OffensiveAbilityData> allOffensiveAbilities = new List<OffensiveAbilityData>(aiPlayer.activeOffensiveAbilities);
        if (aiPlayer.activeUltimate is OffensiveAbilityData ultimate && ultimate != null)
        {
            allOffensiveAbilities.Add(ultimate);
        }

        foreach (var ability in allOffensiveAbilities)
        {
            for (int i = 0; i < ability.activations.Count; i++)
            {
                var activation = ability.activations[i];
                float utility = EvaluateActivationUtility(activation, aiPlayer);
                
                List<int> diceToLock = new List<int>();
                int diceRequired = 5; 

                string typeName = activation.type.ToString();
                if (typeName == "SpecificSymbols")
                {
                    diceToLock = GetDiceToLockForSymbols(activation.symbolsNeeded, currentDice, aiPlayer.characterData.diceKey);
                    diceRequired = activation.symbolsNeeded.Sum(req => req.count);
                }
                else if (typeName == "SmallStraight")
                {
                    diceToLock = GetDiceToLockForStraight(currentDice, 4);
                    diceRequired = 4;
                }
                else if (typeName == "LargeStraight")
                {
                    diceToLock = GetDiceToLockForStraight(currentDice, 5);
                    diceRequired = 5;
                }

                int missingDice = diceRequired - diceToLock.Count;
                if (missingDice < 0) missingDice = 0;

                // one single roll probability
                float pSingle = Mathf.Pow(riskFactor, missingDice);
                
                // cumulative probability, taking into account all rolls
                float p = pSingle;
                if (currentRollsLeft > 1 && missingDice > 0)
                {
                    p = 1f - Mathf.Pow(1f - pSingle, currentRollsLeft);
                }

                // fallback: guaranteed ability?
                float fallbackUtility = 0f;
                List<int> lockedDiceValues = new List<int>();
                for (int j = 0; j < currentDice.Count; j++) lockedDiceValues.Add(diceToLock.Contains(j) ? currentDice[j] : 0);

                foreach (var fbAbility in aiPlayer.activeOffensiveAbilities)
                {
                    var validTiers = AbilityMatcher.GetValidActivations(fbAbility, lockedDiceValues, aiPlayer.characterData.diceKey);
                    foreach (int t in validTiers)
                    {
                        float fbUtil = EvaluateActivationUtility(fbAbility.activations[t], aiPlayer);
                        if (fbUtil > fallbackUtility) fallbackUtility = fbUtil;
                    }
                }

                float expectedGain = Mathf.Max(0f, utility - fallbackUtility);
                float ev = fallbackUtility + (expectedGain * p);
                
                if (!suppressLog) evLog.AppendLine($" - {ability.abilityName} (Tier {i}): Util={utility:F1} | Fallback={fallbackUtility:F1} | Missing={missingDice} | EV={ev:F1} | P={(p*100f):F0}%");

                if (ev > highestEV)
                {
                    highestEV = ev;
                    bestTarget = new RollTargetInfo
                    {
                        ability = ability,
                        tierIndex = i,
                        utilityScore = utility,
                        expectedValue = ev,
                        diceToLock = diceToLock,
                        missingDice = missingDice
                    };
                }
            }
        }

        if (!suppressLog)
        {
            if (bestTarget != null) evLog.Append($" => WINNER: {bestTarget.ability.abilityName} (Tier {bestTarget.tierIndex}) [EV: {bestTarget.expectedValue:F1}]");
            else evLog.Append(" => NO WINNER FOUND.");

            LogAI(evLog.ToString());
        }

        return bestTarget;
    }

    private List<int> GetDiceToLockForSymbols(List<SymbolRequirement> requirements, List<int> currentDice, DiceKeyData diceKey)
    {
        List<int> lockedIndices = new List<int>();
        List<int> availableIndices = Enumerable.Range(0, currentDice.Count).Where(i => currentDice[i] != 0).ToList();

        foreach (var req in requirements)
        {
            int needed = req.count;
            for (int i = availableIndices.Count - 1; i >= 0; i--)
            {
                if (needed <= 0) break;
                int idx = availableIndices[i];
                var symbol = diceKey.GetSymbolForValue(currentDice[idx]);
                
                if (symbol == null) continue;

                bool isMatch = symbol == req.symbol || 
                               (BattleManager.Instance.isSpiderSenseSwapped && req.symbol.name.Contains("Spider") && symbol.name.Contains("Web"));
                
                if (isMatch)
                {
                    lockedIndices.Add(idx);
                    availableIndices.RemoveAt(i);
                    needed--;
                }
            }
        }
        return lockedIndices;
    }

    private List<int> GetDiceToLockForStraight(List<int> currentDice, int targetLength)
    {
        List<int> bestLockIndices = new List<int>();
        int maxConsecutive = 0;

        var uniqueVals = currentDice.Where(v => v != 0).Distinct().OrderBy(v => v).ToList();
        
        for (int i = 0; i < uniqueVals.Count; i++)
        {
            List<int> currentSeqValues = new List<int> { uniqueVals[i] };
            for (int j = i + 1; j < uniqueVals.Count; j++)
            {
                if (uniqueVals[j] == currentSeqValues.Last() + 1)
                {
                    currentSeqValues.Add(uniqueVals[j]);
                }
                else break;
            }

            if (currentSeqValues.Count > maxConsecutive)
            {
                maxConsecutive = currentSeqValues.Count;
                bestLockIndices.Clear();
                foreach (int val in currentSeqValues)
                {
                    int index = currentDice.IndexOf(val);
                    if (index != -1 && !bestLockIndices.Contains(index)) bestLockIndices.Add(index);
                }
            }
        }
        return bestLockIndices;
    }
    #endregion

    #region Target Selection Helpers (The "Eyes")

    // CardResolver
    public PlayerController ChoosePlayerTarget(CardOutcome effect, PlayerController aiCaster)
    {
        PlayerController opponent = (BattleManager.Instance.player1 == aiCaster) ? BattleManager.Instance.player2 : BattleManager.Instance.player1;

        if (effect.actionType == CardActionType.RemoveStatus || effect.actionType == CardActionType.TransferStatus)
        {
            // priority 1: remove a negative status from myself
            if (aiCaster.activeStatuses.Any(s => s.data.type == StatusType.Negative))
            {
                return aiCaster;
            }
            // priority 2: remove a positive status from the opponent
            if (opponent.activeStatuses.Any(s => s.data.type == StatusType.Positive))
            {
                return opponent;
            }
        }
        
        if (effect.actionType == CardActionType.Damage) return opponent;
        if (effect.actionType == CardActionType.Heal) return aiCaster;

        // fallback
        return opponent;
    }

    public StatusEffectsData ChooseTokenTarget(PlayerController target, CardActionType actionType)
    {
        if (actionType == CardActionType.RemoveStatus || actionType == CardActionType.TransferStatus)
        {
            StatusType targetType = (target.isAI) ? StatusType.Negative : StatusType.Positive;
            var token = target.activeStatuses.FirstOrDefault(s => s.data.type == targetType);
            if (token != null) return token.data;
        }
        
        // fallback: pick the first one
        if (target.activeStatuses.Any()) return target.activeStatuses[0].data;
        return null;
    }

    private int lastPickedDieIndex = -1;
    private bool isSelectingSourceDie = false;

    private float GetGuaranteedUtility(PlayerController player, List<int> diceValues)
    {
        float maxUtil = 0f;
        List<OffensiveAbilityData> allOffensiveAbilities = new List<OffensiveAbilityData>(player.activeOffensiveAbilities);
        if (player.activeUltimate is OffensiveAbilityData ultimate && ultimate != null) allOffensiveAbilities.Add(ultimate);

        foreach (var ability in allOffensiveAbilities)
        {
            var validTiers = AbilityMatcher.GetValidActivations(ability, diceValues, player.characterData.diceKey);
            foreach (int t in validTiers)
            {
                float util = EvaluateActivationUtility(ability.activations[t], player);
                if (util > maxUtil) maxUtil = util;
            }
        }
        return maxUtil;
    }

    public int ChooseDieTarget(PlayerController target, CardActionType actionType)
    {
        if (target == null) return 0;
        
        var dice = DiceManager.Instance.dice;
        List<int> currentDice = DiceManager.Instance.GetCurrentDiceValues();
        
        int bestDieIndex = -1;
        float baseUtility = GetGuaranteedUtility(target, currentDice);
        float bestDiff = target.isAI ? 9999f : -9999f;

        // source die selection
        if (actionType == CardActionType.ChangeDiceValueIdenticalToAnother && isSelectingSourceDie)
        {
            isSelectingSourceDie = false;
            int bestSourceIndex = -1;
            float bestSourceScore = target.isAI ? -9999f : 9999f;

            for (int i = 0; i < dice.Count; i++)
            {
                if (!dice[i].isActive || dice[i].currentValue == 0 || i == lastPickedDieIndex) continue;

                List<int> testDice = new List<int>(currentDice);
                testDice[lastPickedDieIndex] = testDice[i]; // simulate the copy

                float score = target.isAI ? (DetermineBestRollTarget(target, testDice, true)?.expectedValue ?? GetGuaranteedUtility(target, testDice)) : GetGuaranteedUtility(target, testDice);
                
                if (target.isAI && score > bestSourceScore) { bestSourceScore = score; bestSourceIndex = i; }
                else if (!target.isAI && score < bestSourceScore) { bestSourceScore = score; bestSourceIndex = i; }
            }
            if (bestSourceIndex != -1) return bestSourceIndex;
        }

        // normal target selection
        for (int i = 0; i < dice.Count; i++)
        {
            if (!dice[i].isActive || dice[i].currentValue == 0) continue;

            List<int> testDice = new List<int>(currentDice);
            testDice[i] = 0; // simulate losing this die
            
            float testUtility = GetGuaranteedUtility(target, testDice);
            float drop = baseUtility - testUtility;

            if (target.isAI)
            {
                // AI wants to change a USELESS die (minimum utility drop)
                if (drop < bestDiff) { bestDiff = drop; bestDieIndex = i; }
            }
            else
            {
                // AI wants to disrupt a CRUCIAL die (maximum utility drop)
                if (drop > bestDiff) { bestDiff = drop; bestDieIndex = i; }
            }
        }

        if (actionType == CardActionType.ChangeDiceValueIdenticalToAnother && !isSelectingSourceDie)
        {
            isSelectingSourceDie = true;
        }

        if (bestDieIndex != -1) 
        {
            lastPickedDieIndex = bestDieIndex;
            return bestDieIndex;
        }

        // fallback
        for (int i = 0; i < dice.Count; i++)
        {
            if (dice[i].isActive && dice[i].currentValue > 0) { lastPickedDieIndex = i; return i; }
        }
        return 0;
    }

    public int ChooseDiceFace(PlayerController target, List<int> validFaces, CardActionType actionType)
    {
        if (validFaces == null || validFaces.Count == 0) return -1;
        if (validFaces.Count == 1) return validFaces[0];

        int dieIndex = lastPickedDieIndex;
        if (dieIndex < 0 || dieIndex >= 5) return validFaces.Max();

        List<int> currentDice = DiceManager.Instance.GetCurrentDiceValues();
        
        int bestFace = validFaces[0];
        float bestScore = target.isAI ? -9999f : 9999f;

        foreach (int face in validFaces)
        {
            List<int> testDice = new List<int>(currentDice);
            testDice[dieIndex] = face;

            float score = 0f;
            if (target.isAI)
            {
                var targetInfo = DetermineBestRollTarget(target, testDice, true);
                score = targetInfo != null ? targetInfo.expectedValue : GetGuaranteedUtility(target, testDice);
            }
            else
            {
                score = GetGuaranteedUtility(target, testDice);
            }

            if (target.isAI && score > bestScore) { bestScore = score; bestFace = face; }
            else if (!target.isAI && score < bestScore) { bestScore = score; bestFace = face; }
        }

        return bestFace;
    }

    #endregion
}