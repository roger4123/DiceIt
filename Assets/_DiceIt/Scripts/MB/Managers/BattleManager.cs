using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum TurnPhase
{
    Upkeep,           // Start of Turn
    Income,           // +1 CP, +1 Card
    MainPhase1,
    OffensiveRollPhase,
    DefensiveRollPhase,
    Resolution,
    MainPhase2,
    Cleanup           // discard cards from hand (limit: 6)
}

public class BattleManager : MonoBehaviour
{
    // Singleton pattern for accessing the manager from anywhere
    public static BattleManager Instance;

    [Header("Players")]
    public PlayerController player1;
    public PlayerController player2;
    
    #region Events & Notifications

    public event Action<TurnPhase> OnPhaseChanged;
    public event Action<string> OnPhaseNotification;
    public event Action OnDefenseSelected;
    public event Action OnAbilityActivated;
    public event Action<PlayerController> OnGameOver;
    public event Action OnCombatSkipped;

    public void NotifyPhase(string message)
    {
        OnPhaseNotification?.Invoke(message);
    }

    #endregion

    #region Game State & Flow
    
    [Header("State")]
    public PlayerController activePlayer;
    public PlayerController opponentPlayer;
    public TurnPhase currentPhase;
    public int currentTurnNumber = 1;
    public bool hasBonusOffensivePhase = false;
    private bool isFirstTurnOfGame = true;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        activePlayer = player1;
        opponentPlayer = player2;
        
        StartNewTurn();
    }

    public void StartNewTurn()
    {
        Debug.Log($"===> {activePlayer.characterData.heroName}'s Turn <===");
        SetPhase(TurnPhase.Upkeep);
    }

    public void SetPhase(TurnPhase newPhase)
    {
        currentPhase = newPhase;
        PlayerController phaseOwner = (currentPhase == TurnPhase.DefensiveRollPhase) ? opponentPlayer : activePlayer;
        Debug.Log($"Starting Phase: {currentPhase} for {phaseOwner.characterData.heroName}");        

        // reset state vars before launching OnPhaseChanged
        if (currentPhase == TurnPhase.OffensiveRollPhase || currentPhase == TurnPhase.DefensiveRollPhase)
        {
            hasActivatedAbilityThisPhase = false;
            pendingDefenseSelection = null;
            needsDefenseSelection = false;
        }

        // global rule: disable dice interaction if it's not a roll phase
        if (newPhase != TurnPhase.OffensiveRollPhase && newPhase != TurnPhase.DefensiveRollPhase)
        {
            if (DiceManager.Instance != null) DiceManager.Instance.SetInteractionState(DiceInteractionState.Disabled);
        }

        OnPhaseChanged?.Invoke(currentPhase);

        switch (currentPhase)
        {
            case TurnPhase.Upkeep:
                StartCoroutine(ProcessUpkeepRoutine());
                break;

            case TurnPhase.Income:
                StartCoroutine(ProcessIncomeRoutine());
                break;

            case TurnPhase.MainPhase1:
                if (ActionStackManager.Instance != null) ActionStackManager.Instance.BeginInteractivePhase();
                break;

            case TurnPhase.OffensiveRollPhase:
                if (DiceManager.Instance != null)
                {
                    DiceManager.Instance.ResetDice(3);
                    DiceManager.Instance.SetInteractionState(DiceInteractionState.PlayerLocking);
                }
                if (ActionStackManager.Instance != null) ActionStackManager.Instance.BeginInteractivePhase();
                break;

            case TurnPhase.DefensiveRollPhase:
                canActivateDefensiveAbility = (committedOffense != null);
                
                if (committedOffense != null)
                {
                    if (committedOffense.runtimeAttackType != DamageType.Normal)
                    {
                        canActivateDefensiveAbility = false;
                        OnPhaseNotification?.Invoke($"Damage Type: {committedOffense.runtimeAttackType}. Cannot activate Defensive Ability!");
                        //Debug.LogWarning($"[BattleManager] Damage Type is {offAb.attackType}. Opponent cannot activate a Defensive Ability.");
                    }
                }

                if (DiceManager.Instance != null)
                {
                    if (canActivateDefensiveAbility && opponentPlayer.activeDefensiveAbilities.Count > 0)
                    {
                        if (opponentPlayer.activeDefensiveAbilities.Count == 1)
                        {
                            SelectDefense(opponentPlayer.activeDefensiveAbilities[0]);
                        }
                        else
                        {
                            // stop the dice until Defensive Ability selection
                            needsDefenseSelection = true;
                            DiceManager.Instance.ResetDice(1, 0); 
                            DiceManager.Instance.SetInteractionState(DiceInteractionState.Disabled);
                        }
                    }
                    else 
                    {
                        DiceManager.Instance.ResetDice(1, 0);
                        DiceManager.Instance.SetInteractionState(DiceInteractionState.Disabled);
                    }
                }
                if (ActionStackManager.Instance != null) ActionStackManager.Instance.BeginInteractivePhase(opponentPlayer);
                break;
            
            case TurnPhase.Resolution:
                StartCoroutine(ProcessResolutionRoutine());
                break;

            case TurnPhase.MainPhase2:
                if (ActionStackManager.Instance != null) ActionStackManager.Instance.BeginInteractivePhase();
                break;

            case TurnPhase.Cleanup:
                StartCoroutine(ProcessCleanupRoutine());
                break;
        }
    }

    public void AdvancePhase()
    {
        switch (currentPhase)
        {
            case TurnPhase.MainPhase1:
                SetPhase(TurnPhase.OffensiveRollPhase);
                break;

            case TurnPhase.OffensiveRollPhase:
                CommitPendingAbilities();
                if (committedOffense != null)
                {
                    // WEBBED PASSIVE CHECK
                    if (committedOffense.runtimeAttackType == DamageType.Normal)
                    {
                        var webbed = opponentPlayer.activeStatuses.FirstOrDefault(s => s.data.effectName == "Webbed");
                        // shouldn't have effect if applied this turn
                        if (webbed != null && webbed.turnInflicted < currentTurnNumber)
                        {
                            Debug.Log($"[BattleManager] WEBBED triggered! {opponentPlayer.characterData.heroName}'s token changes the attack to Undefendable!");
                            committedOffense.runtimeAttackType = DamageType.Undefendable;
                            opponentPlayer.RemoveStatus(webbed.data, 0);
                        }
                    }

                    SetPhase(TurnPhase.DefensiveRollPhase);
                }
                else
                {
                    OnPhaseNotification?.Invoke($"No incoming Attack from {activePlayer.characterData.heroName}. Skipping to Main Phase II!");
                    StartCoroutine(SkipCombatAndAdvanceToMainPhase2());
                }
                break;

            case TurnPhase.DefensiveRollPhase:
                CommitPendingAbilities();
                SetPhase(TurnPhase.Resolution);
                break;

            case TurnPhase.Resolution:
                // This is called when the stack is empty and both players passed.
                // Mutat comportamentul în corutina ProcessResolutionRoutine
                break;

            case TurnPhase.MainPhase2:
                SetPhase(TurnPhase.Cleanup);
                break;

            default:
                Debug.Log("AdvancePhase was called in an automatic phase. Ignoring the action.");
                break;
        }
    }

    public void EndTurn()
    {
        PlayerController temp = activePlayer;
        activePlayer = opponentPlayer;
        opponentPlayer = temp;

        currentTurnNumber++;
        StartNewTurn();
    }

    public void TriggerGameOver(PlayerController loser)
    {
        PlayerController winner = (loser == player1) ? player2 : player1;
        Debug.Log($"[Game Over] {winner.characterData.heroName} won the match!");
        OnGameOver?.Invoke(winner);
    }
    #endregion


    #region Phase Coroutines

    private IEnumerator ProcessResolutionRoutine()
    {
        OnPhaseNotification?.Invoke("Resolution Phase: Resolving combat...");
        yield return new WaitForSeconds(1.5f);

        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.ResolveAllPendingActions();
        }

        yield return new WaitForSeconds(1.5f);

        ClearCombatIntent();
        
        if (hasBonusOffensivePhase)
        {
            hasBonusOffensivePhase = false;
            Debug.Log("[BattleManager] COMBO token resolved! Starting a Bonus Offensive Roll Phase!");
            SetPhase(TurnPhase.OffensiveRollPhase);
        }
        else
        {
            SetPhase(TurnPhase.MainPhase2);
        }
    }

    private IEnumerator ProcessUpkeepRoutine()
    {
        OnPhaseNotification?.Invoke("Upkeep: No Status Effects to check.");
        yield return new WaitForSeconds(2.5f);

        // TODO: iterare prin Status Effects active si check for OnTurnStart types
        // momentan e skippable
        SetPhase(TurnPhase.Income);
    }

    private IEnumerator ProcessIncomeRoutine()
    {
        if (isFirstTurnOfGame)
        {
            isFirstTurnOfGame = false;
            OnPhaseNotification?.Invoke("Starting player skips the first Income Phase!");
            yield return new WaitForSeconds(2.5f);
        }
        else
        {
            OnPhaseNotification?.Invoke("Income: +1 CP, +1 Card");
            yield return new WaitForSeconds(2.5f);

            activePlayer.ChangeCP(1);
            activePlayer.DrawCards(1);
        }

        SetPhase(TurnPhase.MainPhase1);
    }

    private IEnumerator ProcessCleanupRoutine()
    {
        if (activePlayer.hand.Count > 6)
        {
            while (activePlayer.hand.Count > 6)
            {
                int overLimit = activePlayer.hand.Count - 6;
                OnPhaseNotification?.Invoke($"Cleanup Phase: Please discard {overLimit} card(s)!");
                
                int currentCount = activePlayer.hand.Count;
                yield return new WaitUntil(() => activePlayer.hand.Count < currentCount);
            }
        }
        else
        {
            OnPhaseNotification?.Invoke("Cleanup Phase: Hand size is within limit.");
            yield return new WaitForSeconds(1.5f);
        }

        EndTurn();
    }

    private IEnumerator SkipCombatAndAdvanceToMainPhase2()
    {
        OnCombatSkipped?.Invoke();

        yield return new WaitForSeconds(2.5f);
        
        ClearCombatIntent();
        SetPhase(TurnPhase.MainPhase2);
    }

    /// outcomes that should happen instantly upon declaration, before stack resolution
    public void ApplyInstantEffects(AbilityOutcome outcome, PlayerController source, PlayerController opponent, float scalingMultiplier = 1f)
    {
        PlayerController target = (outcome.target == StatusTarget.Opponent) ? opponent : source;

        float finalValue = outcome.isScaling ? outcome.value * scalingMultiplier : outcome.value;

        switch (outcome.type)
        {
            case OutcomeType.GainCP: 
                target.ChangeCP(Mathf.CeilToInt(finalValue)); 
                break;
            case OutcomeType.DrawCard: 
                target.DrawCards(Mathf.CeilToInt(finalValue)); 
                break;
        }

        if (outcome.statuses != null)
        {
            foreach (var statusApp in outcome.statuses)
            {
                int amountToAdd = outcome.isScaling ? Mathf.CeilToInt(finalValue) : statusApp.amount;
                target.AddStatus(statusApp.status, amountToAdd);
            }
        }
    }

    #endregion

    #region Combat Intent & Activation

    [Header("Combat State")]
    public bool hasActivatedAbilityThisPhase = false;
    public bool needsDefenseSelection = false;
    public bool canActivateDefensiveAbility = true;
    private bool isPerformingSpecialRoll = false;

    [Header("Pending Selections")]
    public DefensiveAbilityData pendingDefenseSelection;
    public OffensiveAbilityData pendingOffensiveAbility;
    public int pendingOffensiveTierIndex = -1;
    public DefensiveAbilityData pendingDefensiveAbility;
    private List<int> pendingSecondaryRollResults = new List<int>();

    [Header("Committed Actions")]
    public ActivateAbilityAction committedOffense;
    public ActivateAbilityAction committedDefense;

    [Header("Turn-wide Combat Modifiers")]
    public float turnDamagePrevention = 0f;

    public void MarkAbilityActivated()
    {
        hasActivatedAbilityThisPhase = true;
        OnAbilityActivated?.Invoke();
    }

    public void SelectDefense(DefensiveAbilityData defAbility)
    {
        pendingDefenseSelection = defAbility;
        needsDefenseSelection = false;
        
        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.ResetDice(1, defAbility.diceToRoll);
            DiceManager.Instance.SetInteractionState(DiceInteractionState.PlayerLocking);
        }
        
        OnDefenseSelected?.Invoke();
        Debug.Log($"[BattleManager] Defense selected: {defAbility.abilityName}. Rolling {defAbility.diceToRoll} dice.");
    }

    public void SetPendingOffensiveAbility(OffensiveAbilityData ability, int tierIndex)
    {
        pendingOffensiveAbility = ability;
        pendingOffensiveTierIndex = tierIndex;
        Debug.Log($"[BattleManager] {activePlayer.characterData.heroName} selected {ability.abilityName} as pending attack.");

        var activation = ability.activations[tierIndex];
        if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
        {
            StartCoroutine(PerformSecondaryRollsAndStoreRoutine(activation));
        }
        else
        {
            if (ActionStackManager.Instance != null) ActionStackManager.Instance.PassPriority(true);
        }
    }

    public void SetPendingDefensiveAbility(DefensiveAbilityData ability)
    {
        pendingDefensiveAbility = ability;
        Debug.Log($"[BattleManager] {opponentPlayer.characterData.heroName} selected {ability.abilityName} as pending defense.");
        
        if (ActionStackManager.Instance != null) ActionStackManager.Instance.PassPriority(true);
    }

    private IEnumerator PerformSecondaryRollsAndStoreRoutine(OffensiveAbilityData.AttackActivation activation)
    {
        isPerformingSpecialRoll = true;
        pendingSecondaryRollResults.Clear();
        NotifyPhase("Rolling for ability effect...");
        yield return new WaitForSeconds(1.0f);

        DiceManager.Instance.StoreDiceState();

        var secRoll = activation.secondaryRolls[0];
        int diceToRoll = secRoll.diceCount;

        DiceManager.Instance.ResetDice(1, diceToRoll);
        yield return new WaitForSeconds(0.5f);
        
        DiceManager.Instance.RollDice();
        yield return new WaitForSeconds(1.5f);

        List<int> rolledValues = DiceManager.Instance.GetCurrentDiceValues();
        foreach (var value in rolledValues)
        {
            if (value > 0)
            {
                pendingSecondaryRollResults.Add(value);
            }
        }

        yield return new WaitForSeconds(2.0f);

        DiceManager.Instance.RestoreDiceState();
        yield return new WaitForSeconds(0.5f);

        isPerformingSpecialRoll = false;

        if (ActionStackManager.Instance != null) ActionStackManager.Instance.PassPriority(true);
    }

    public void ValidatePendingAbilities()
    {
        if (isPerformingSpecialRoll) return;

        if (pendingOffensiveAbility != null && currentPhase == TurnPhase.OffensiveRollPhase)
        {
            var currentDice = DiceManager.Instance.GetCurrentDiceValues();
            var validTiers = AbilityMatcher.GetValidActivations(pendingOffensiveAbility, currentDice, activePlayer.characterData.diceKey);
            
            if (!validTiers.Contains(pendingOffensiveTierIndex))
            {
                Debug.LogWarning($"[BattleManager] Pending ability {pendingOffensiveAbility.abilityName} is NO LONGER VALID due to dice changes!");
                pendingOffensiveAbility = null;
                pendingOffensiveTierIndex = -1;
                hasActivatedAbilityThisPhase = false; 
                OnPhaseChanged?.Invoke(currentPhase);
            }
        }
    }

    private void CommitPendingAbilities()
    {
        if (currentPhase == TurnPhase.OffensiveRollPhase && pendingOffensiveAbility != null)
        {
            committedOffense = new ActivateAbilityAction(activePlayer, pendingOffensiveAbility, pendingOffensiveTierIndex, new List<int>(pendingSecondaryRollResults));
            ActionStackManager.Instance.AddActionToStack(committedOffense);
            Debug.Log($"[BattleManager] Committed {pendingOffensiveAbility.abilityName} to the Action Stack.");
        }
        else if (currentPhase == TurnPhase.DefensiveRollPhase && pendingDefensiveAbility != null)
        {
            committedDefense = new ActivateAbilityAction(opponentPlayer, pendingDefensiveAbility, -1);
            ActionStackManager.Instance.AddActionToStack(committedDefense);
            Debug.Log($"[BattleManager] Committed {pendingDefensiveAbility.abilityName} to the Action Stack.");
        }
    }

    private void ClearCombatIntent()
    {
        committedOffense = null;
        committedDefense = null;
        pendingOffensiveAbility = null;
        pendingOffensiveTierIndex = -1;
        pendingDefensiveAbility = null;
        pendingSecondaryRollResults.Clear();
    }

    public void AddTurnPrevention(float value)
    {
        turnDamagePrevention += value;
        Debug.Log($"[BattleManager] Added {value} to turn prevention. Total: {turnDamagePrevention}");
    }

    public float GetAndClearTurnPrevention()
    {
        float value = turnDamagePrevention;
        turnDamagePrevention = 0f;
        return value;
    }
    #endregion

    #region Combat Resolution Logic

    /// checks if the conditions for an ability outcome are met based on the rolled dice
    public bool IsConditionMet(AbilityOutcome outcome, List<int> rolledValues, DiceKeyData diceKey, out float scalingMultiplier)
    {
        scalingMultiplier = 1f;

        if (outcome.condition == ConditionType.Always) return true;

        if (outcome.condition == ConditionType.SpecificSymbols)
        {
            if (outcome.symbolRequirements == null || outcome.symbolRequirements.Count == 0) return false;

            int minSets = int.MaxValue;
            foreach (var req in outcome.symbolRequirements)
            {
                int countInRoll = 0;
                foreach (int val in rolledValues)
                {
                    if (val == 0) continue;
                    var symbolData = diceKey.GetSymbolForValue(val);
                    if (symbolData != null && symbolData == req.symbol) countInRoll++;
                }
                if (countInRoll < req.count) return false;
                minSets = Mathf.Min(minSets, countInRoll / Mathf.Max(1, req.count));
            }
            
            if (outcome.isScaling) scalingMultiplier = minSets;
            return true;
        }

        if (outcome.condition == ConditionType.SumValue)
        {
            int sum = 0;
            foreach (int v in rolledValues) sum += v;
            
            if (outcome.isScaling) scalingMultiplier = sum;

            switch (outcome.compareMode)
            {
                case CompareMode.LessOrEqual: return sum <= outcome.threshold;
                case CompareMode.GreaterOrEqual: return sum >= outcome.threshold;
                case CompareMode.Exactly: return sum == outcome.threshold;
                case CompareMode.None: return true;
            }
        }

        return false;
    }
    
    #endregion
}