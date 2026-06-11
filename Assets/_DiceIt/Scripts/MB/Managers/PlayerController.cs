using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;

// instanta activa a unui player in timpul jocului
// gestionare HP, CP si Status Effects
public class PlayerController : MonoBehaviour   
{
    [Header("Data Reference")]
    public CharacterData characterData;
    public bool isAI = false;

    [Header("Runtime Stats")]
    public int currentHealth;
    public int currentCombatPoints;

    [Header("Runtime Abilities")]
    public List<OffensiveAbilityData> activeOffensiveAbilities = new List<OffensiveAbilityData>();
    public List<DefensiveAbilityData> activeDefensiveAbilities = new List<DefensiveAbilityData>();
    public BaseAbilityData activeUltimate;
    public PassiveAbilityData activePassive;

    [Header("Card Management")]
    public List<CardData> drawDeck = new List<CardData>();
    public List<CardData> hand = new List<CardData>();
    public List<CardData> discardPile = new List<CardData>();

    private bool isResolvingPassive = false;

    // Events
    public event Action<int, int, int, int> OnStatsChanged;
    public event Action<CharacterData, PlayerController> OnCharacterInitialization;
    public event Action OnHandChanged;
    public event Action OnDeckChanged;
    public event Action OnDiscardChanged;
    public event Action OnAbilitiesChanged;
    public event Action OnStatusChanged;

    [System.Serializable]
    public class ActiveStatus
    {
        public StatusEffectsData data;
        public int currentStacks;
        public int turnInflicted;

        public ActiveStatus(StatusEffectsData data, int amount, int turn)
        {
            this.data = data;
            currentStacks = amount;
            turnInflicted = turn;
        }
    }
    public List<ActiveStatus> activeStatuses = new List<ActiveStatus>();

    public void InitializePlayer()
    {
        if (characterData == null) return;

        currentHealth = characterData.maxHealth;
        currentCombatPoints = characterData.startingCombatPoints;
        activeStatuses.Clear();
        InitializeAbilities();

        InitializeDeck();
        
        Debug.Log($"{characterData.heroName} initialized with {currentHealth} HP and {drawDeck.Count} cards.");

        OnCharacterInitialization?.Invoke(characterData, this);
        BroadcastStats();
    }
    
    private void Start()
    {
        InitializePlayer();
    }

    #region Deck & Hand Logic

    public void ShuffleDeck()
    {
        for (int i = 0; i < drawDeck.Count; i++)
        {
            CardData temp = drawDeck[i];
            int randomIndex = UnityEngine.Random.Range(i, drawDeck.Count);
            drawDeck[i] = drawDeck[randomIndex];
            drawDeck[randomIndex] = temp;
        }
    }

    public void DrawCards(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (drawDeck.Count == 0)
            {
                if (discardPile.Count > 0)
                {
                    drawDeck.AddRange(discardPile);
                    discardPile.Clear();
                    ShuffleDeck();
                    UI_CombatLog.Instance?.LogMessage($"{characterData.heroName}'s discard pile reshuffled into draw deck.", Color.black);
                    BattleManager.Instance?.ShowNotification($"{characterData.heroName}'s discard pile reshuffled!", 2.0f);
                    OnDiscardChanged?.Invoke();
                }
                else
                {
                    Debug.LogWarning("No more cards to draw!");
                    UI_CombatLog.Instance?.LogMessage($"{characterData.heroName} has no more cards to draw!", Color.black);
                    BattleManager.Instance?.ShowNotification("No more cards to draw!", 2.0f);
                    break;
                }
            }

            CardData card = drawDeck[0];
            drawDeck.RemoveAt(0);
            hand.Add(card);
        }
        
        OnHandChanged?.Invoke();
        OnDeckChanged?.Invoke();
    }

    private void InitializeDeck()
    {
        drawDeck.Clear();
        hand.Clear();
        discardPile.Clear();

        if (characterData.deckRecipe != null)
        {
            foreach (var card in characterData.deckRecipe.cards)
            {
                if (card != null) drawDeck.Add(card);
            }
            ShuffleDeck();
        }

        DrawCards(characterData.startingCards);
        
        OnDeckChanged?.Invoke();
        OnDiscardChanged?.Invoke();
    }

    public void DiscardCard(CardData card)
    {
        if (hand.Contains(card))
        {
            hand.Remove(card);
            discardPile.Add(card);
            OnHandChanged?.Invoke();
            OnDiscardChanged?.Invoke();
        }
    }

    public void BanishCard(CardData card)
    {
        if (hand.Contains(card))
        {
            hand.Remove(card);
            OnHandChanged?.Invoke();
        }
    }

    public bool CanAffordToPlayCard(CardData card)
    {
        return currentCombatPoints >= card.cpCost;
    }

    #endregion

    #region Abilities & Upgrades

    private void InitializeAbilities()
    {
        activeOffensiveAbilities.Clear();
        if (characterData.offensiveAbilities != null)
            activeOffensiveAbilities.AddRange(characterData.offensiveAbilities);

        activeDefensiveAbilities.Clear();
        if (characterData.defensiveAbilities != null)
            activeDefensiveAbilities.AddRange(characterData.defensiveAbilities);

        activeUltimate = characterData.ultimateAbility;
        activePassive = characterData.passive;
    }

    public void ApplyUpgrade(BaseAbilityData oldAbility, BaseAbilityData newAbility)
    {
        if (oldAbility == null || newAbility == null) return;
        
        bool wasUpgraded = false;

        if (oldAbility is OffensiveAbilityData oldOffensive && newAbility is OffensiveAbilityData newOffensive)
        {
            int index = activeOffensiveAbilities.IndexOf(oldOffensive);
            if (index != -1) { activeOffensiveAbilities[index] = newOffensive; wasUpgraded = true; }
        }
        else if (oldAbility is DefensiveAbilityData oldDefensive && newAbility is DefensiveAbilityData newDefensive)
        {
            int index = activeDefensiveAbilities.IndexOf(oldDefensive);
            if (index != -1) { activeDefensiveAbilities[index] = newDefensive; wasUpgraded = true; }
        }
        else if (activeUltimate == oldAbility)
        {
            activeUltimate = newAbility;
            wasUpgraded = true;
        }
        else if (activePassive == oldAbility && newAbility is PassiveAbilityData newPassive)
        {
            activePassive = newPassive;
            wasUpgraded = true;
        }

        if (wasUpgraded)
        {
            UI_CombatLog.Instance?.LogMessage($"{characterData.heroName} upgraded '{oldAbility.abilityName}' to {newAbility.abilityName}!", Color.black);
            BattleManager.Instance?.ShowNotification($"'{oldAbility.abilityName}' upgraded!", 2.5f);
            OnAbilitiesChanged?.Invoke();
        }
    }

    #endregion

    #region Health & Resources
    
    public void ChangeHealth(int amount, DamageType damageType = DamageType.Normal)
    {
        int oldHealth = currentHealth;
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, characterData.maxHealth);
        
        int actualDamageTaken = oldHealth - currentHealth;

        //  OnDamageTaken trigger (for Energy Absorption)
        if (actualDamageTaken > 0 && activePassive != null && activePassive.trigger == PassiveTrigger.OnDamageTaken && !isResolvingPassive)
        {
            if (!(activePassive.ignoreUltimate && damageType == DamageType.Ultimate))
            {
                isResolvingPassive = true;
                Debug.Log($"[Passive] {characterData.heroName}'s passive {activePassive.abilityName} triggered from taking {actualDamageTaken} DMG!");
                UI_CombatLog.Instance?.LogMessage($"{characterData.heroName}'s '{activePassive.abilityName}' triggered! (Taken {actualDamageTaken} DMG)", Color.black);
                foreach (var effect in activePassive.primaryPassiveOutcomes)
                {
                    ApplyOutcome(effect);
                }
                isResolvingPassive = false;
            }
        }

        if (currentHealth <= 0)
        {
            Debug.Log($"{characterData.heroName} was defeated!");
            BattleManager.Instance?.TriggerGameOver(this);
        }

        BroadcastStats();
    }

    public void ChangeCP(int amount)
    {
        currentCombatPoints = Mathf.Clamp(currentCombatPoints + amount, 0, characterData.maxCombatPoints);
        BroadcastStats();
    }

    private void BroadcastStats()
    {
        OnStatsChanged?.Invoke(currentHealth, characterData.maxHealth, currentCombatPoints, characterData.maxCombatPoints);
    }

    #endregion

    #region Status Management

    public void AddStatus(StatusEffectsData status, int amount)
    {
        // check global limit
        if (status.maxGlobalTokens > 0)
        {
            int p1Stacks = BattleManager.Instance.player1.activeStatuses.FirstOrDefault(s => s.data == status)?.currentStacks ?? 0;
            int p2Stacks = BattleManager.Instance.player2.activeStatuses.FirstOrDefault(s => s.data == status)?.currentStacks ?? 0;
            int currentGlobalStacks = p1Stacks + p2Stacks;

            if (currentGlobalStacks >= status.maxGlobalTokens)
            {
                Debug.Log($"[Status] Cannot add {status.effectName}. Global limit ({status.maxGlobalTokens}) reached!");
                UI_CombatLog.Instance?.LogMessage($"Cannot add {status.effectName}. Global limit ({status.maxGlobalTokens}) reached!", Color.black);
                BattleManager.Instance?.ShowNotification($"Cannot add {status.effectName}. Global limit ({status.maxGlobalTokens}) reached!", 2.5f);
                return;
            }
            
            amount = Mathf.Min(amount, status.maxGlobalTokens - currentGlobalStacks);
        }

        var existing = activeStatuses.FirstOrDefault(s => s.data == status);

        bool reachedLimit = false;

        if (existing != null)
        {
            if (existing.currentStacks >= status.stackLimit)
            {
                Debug.Log($"[Status] {characterData.heroName}: Stack limit reached for {status.effectName}!");
                UI_CombatLog.Instance?.LogMessage($"{characterData.heroName}: Stack limit reached for {status.effectName}!", Color.black);
                BattleManager.Instance?.ShowNotification($"{characterData.heroName}: Stack limit reached for {status.effectName}!", 2.5f);
                return;
            }
            
            existing.currentStacks += amount;
            if (existing.currentStacks >= status.stackLimit)
            {
                existing.currentStacks = status.stackLimit;
                reachedLimit = true;
            }
        }
        else
        {
            int currentTurn = BattleManager.Instance != null ? BattleManager.Instance.currentTurnNumber : 1;
            int finalAmount = Mathf.Min(amount, status.stackLimit);
            activeStatuses.Add(new ActiveStatus(status, finalAmount, currentTurn));
            
            if (finalAmount >= status.stackLimit) reachedLimit = true;
        }
        
        OnStatusChanged?.Invoke();
        Debug.Log($"{characterData.heroName} gained Status Effect: {status.effectName} (+{amount})");
        UI_CombatLog.Instance?.LogMessage($"{characterData.heroName} gained {amount} {status.effectName}.", Color.black);

        // trigger the "Stack Limit Reached" effects
        if (reachedLimit && status.primaryStatusEffectOutcomes != null && status.primaryStatusEffectOutcomes.Any(o => o.activationTrigger == StatusTrigger.ReachingStackLimit))
        {
            Debug.Log($"[Status] {status.effectName} reached Stack Limit! Triggering overload effects...");
            UI_CombatLog.Instance?.LogMessage($"{status.effectName} reached Stack Limit! Triggering overload.", Color.black);
            BattleManager.Instance?.ShowNotification($"{status.effectName} Overload!", 2.5f);

            StatusResolver.Instance?.ResolveTrigger(StatusTrigger.ReachingStackLimit, this, status);
            
            RemoveStatus(status, 0);
        }
    }

    public void RemoveStatus(StatusEffectsData status, int amount = 1)
    {
        var existing = activeStatuses.FirstOrDefault(s => s.data == status);
        if (existing != null)
        {
            if (amount == 0)
            {
                activeStatuses.Remove(existing);
            }
            else
            {
                existing.currentStacks -= amount;
                if (existing.currentStacks <= 0)
                {
                    activeStatuses.Remove(existing);
                }
            }
            
            OnStatusChanged?.Invoke();
        }
    }

    public void ClearAllStatuses()
    {
        activeStatuses.Clear();
        OnStatusChanged?.Invoke();
        Debug.Log($"{characterData.heroName} was cleansed of ALL status effects!");
        UI_CombatLog.Instance?.LogMessage($"{characterData.heroName} was cleansed of ALL status effects!", Color.black);
    }

    public bool CanSpendStatus(StatusEffectsData status)
    {
        var bm = BattleManager.Instance;

        if (status.effectName == "Combo")
        {
            // condition 1: only in the opponent's DefensiveRollPhase
            if (bm.currentPhase != TurnPhase.DefensiveRollPhase) return false;
            if (bm.activePlayer != this) return false;
            
            // condition 2: you commited an attack to the stack
            if (bm.committedOffense == null || bm.committedOffense.SourcePlayer != this) return false;
            
            return true;
        }
        
        if (status.effectName == "Invisibility")
        {
            // only in DefensiveRollPhase, when attacked with Undefendable
            if (bm.currentPhase != TurnPhase.DefensiveRollPhase) return false;
            if (bm.opponentPlayer != this) return false;

            // Motivul 1: Atac Undefendable
            if (bm.committedOffense != null && bm.committedOffense.runtimeAttackType == DamageType.Undefendable && !bm.canActivateDefensiveAbility) 
                return true;

            // Motivul 2: Roll-uri extra pentru Spider Sense
            if (bm.pendingDefenseSelection != null)
            {
                foreach (var outcome in bm.pendingDefenseSelection.primaryDefensiveOutcomes)
                {
                    if (outcome.type == AbilityOutcomeType.ModifyRollAttempts && outcome.statuses != null)
                    {
                        if (outcome.statuses.Any(s => s.status.effectName == "Invisibility" && s.amount < 0)) return true;
                    }
                }
            }

            return false;
        }

        if (status.effectName == "Vibranium Suit")
        {
            if (bm.currentPhase != TurnPhase.DefensiveRollPhase) return false;
            if (bm.opponentPlayer != this) return false;
            if (bm.committedOffense == null) return false;

            return true;
        }

        return true;
    }

    public void SpendStatus(StatusEffectsData status)
    {
        var existing = activeStatuses.FirstOrDefault(s => s.data == status);
        if (existing != null && existing.currentStacks > 0)
        {
            RemoveStatus(status, 1);
            Debug.Log($"{characterData.heroName} spent 1 token of {status.effectName}.");
            UI_CombatLog.Instance?.LogMessage($"{characterData.heroName} spent 1 {status.effectName}.", Color.black);
            BattleManager.Instance?.ShowNotification($"{characterData.heroName} spent 1 {status.effectName}!", 1.5f);

            if (ActionStackManager.Instance != null)
            {
                ActionStackManager.Instance.ResetPriorityPasses();
                var action = new SpendTokenAction(this, status);
                ActionStackManager.Instance.AddActionToStack(action);
            }
        }
    }

    #endregion

    #region Outcome Processing

    private void ProcessNumericalOutcome(AbilityOutcome outcome)
    {
        switch (outcome.type)
        {
            case AbilityOutcomeType.Damage:
                ChangeHealth(-(int)outcome.value);
                break;

            case AbilityOutcomeType.Healing:
                ChangeHealth((int)outcome.value);
                break;

            case AbilityOutcomeType.GainCP:
                ChangeCP((int)outcome.value);
                break;

            case AbilityOutcomeType.Prevent:
                BattleManager.Instance?.AddTurnPrevention(this, outcome.value);
                break;
                
            case AbilityOutcomeType.PreventHalfDamage:
                BattleManager.Instance?.HalveTurnDamage();
                break;

            case AbilityOutcomeType.None:
                break;
                
            default:
                Debug.LogWarning($"OutcomeType {outcome.type} not implemented yet.");
                break;
        }
    }

    public void ApplyOutcome(AbilityOutcome outcome)
    {
        ProcessNumericalOutcome(outcome);

        foreach (var statusApp in outcome.statuses)
        {
            AddStatus(statusApp.status, statusApp.amount);
        }
    }

    #endregion
}