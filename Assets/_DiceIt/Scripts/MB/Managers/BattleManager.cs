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

    private Coroutine activeNotificationCoroutine;

    public void NotifyPhase(string message)
    {
        if (activeNotificationCoroutine != null)
        {
            StopCoroutine(activeNotificationCoroutine);
            activeNotificationCoroutine = null;
        }
        OnPhaseNotification?.Invoke(message);
    }

    public Coroutine ShowNotification(string message, float duration)
    {
        if (activeNotificationCoroutine != null)
        {
            StopCoroutine(activeNotificationCoroutine);
            activeNotificationCoroutine = null;
        }
        
        OnPhaseNotification?.Invoke(message);
        activeNotificationCoroutine = StartCoroutine(WaitAndHideRoutine(duration));
        return activeNotificationCoroutine;
    }

    private IEnumerator WaitAndHideRoutine(float duration)
    {
        yield return new WaitForSeconds(duration);
        OnPhaseNotification?.Invoke("");
        activeNotificationCoroutine = null;
    }

    #endregion

    #region Game State & Flow
    
    [Header("State")]
    public PlayerController activePlayer;
    public PlayerController opponentPlayer;
    public TurnPhase currentPhase;
    public int currentTurnNumber = 1;
    public bool hasBonusOffensivePhase = false;
    public bool hasUsedComboThisTurn = false;
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
        StartCoroutine(StartNewTurnRoutine());
    }

    private IEnumerator StartNewTurnRoutine()
    {
        Debug.Log($"=> Starting turn {currentTurnNumber}: {activePlayer.characterData.heroName}'s turn");
        hasUsedComboThisTurn = false;
        UI_CombatLog.Instance?.LogMessage($"Turn {currentTurnNumber}: {activePlayer.characterData.heroName.ToUpper()}", Color.black);
        yield return ShowNotification($"Starting turn {currentTurnNumber}: {activePlayer.characterData.heroName}'s turn.", 2.5f);
        
        SetPhase(TurnPhase.Upkeep);
    }

    public void SetPhase(TurnPhase newPhase)
    {
        currentPhase = newPhase;
        PlayerController phaseOwner = (currentPhase == TurnPhase.DefensiveRollPhase) ? opponentPlayer : activePlayer;

        Debug.Log($"Starting Phase: {currentPhase} for {phaseOwner.characterData.heroName}");   
        UI_CombatLog.Instance?.LogMessage($"{currentPhase} for {phaseOwner.characterData.heroName}", Color.black);
        ShowNotification($"{currentPhase} for {phaseOwner.characterData.heroName}", 2.5f);

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
                        NotifyPhase($"Damage Type: {committedOffense.runtimeAttackType}. Cannot activate Defensive Ability!");
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
                            Debug.Log($"[BattleManager] WEBBED triggered! {opponentPlayer.characterData.heroName}'s token changes the next attack to Undefendable!");
                            UI_CombatLog.Instance?.LogMessage($"Webbed triggered! {opponentPlayer.characterData.heroName}'s token changes the next attack to Undefendable!", Color.black);
                        ShowNotification($"Webbed triggered! {opponentPlayer.characterData.heroName}'s token changes the next attack to Undefendable!", 2.5f);
                            committedOffense.runtimeAttackType = DamageType.Undefendable;
                            opponentPlayer.RemoveStatus(webbed.data, 0);
                        }
                    }

                    SetPhase(TurnPhase.DefensiveRollPhase);
                }
                else
                {
                    UI_CombatLog.Instance?.LogMessage($"{activePlayer.characterData.heroName} didn't activate an attack this turn.", Color.black);
                    StartCoroutine(SkipCombatAndAdvanceToMainPhase2($"No incoming Attack from {activePlayer.characterData.heroName}. Skipping to Main Phase 2!"));
                }
                break;

            case TurnPhase.DefensiveRollPhase:
                CommitPendingAbilities();
                SetPhase(TurnPhase.Resolution);
                break;

            case TurnPhase.Resolution:
                // This is called when the stack is empty and both players passed.
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
        
        AIDataLogger.Instance?.LogPlayerAction(winner, "GameOver", "Victory");
        AIDataLogger.Instance?.LogPlayerAction(loser, "GameOver", "Defeat");

        OnGameOver?.Invoke(winner);
    }
    #endregion


    #region Phase Coroutines

    private IEnumerator ProcessResolutionRoutine()
    {
        yield return ShowNotification("Resolution Phase: Resolving combat...", 1.5f);

        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.ResolveAllPendingActions();
        }

        // resolve Defense logic first (so damage prevention applies)
        if (committedDefense != null)
        {
            committedDefense.Execute();
        }

        // resolve Offense logic (damage is calculated against prevention)
        if (committedOffense != null)
        {
            committedOffense.Execute();
        }

        yield return new WaitForSeconds(1.5f);

        ClearCombatIntent();
        
        if (hasBonusOffensivePhase)
        {
            hasBonusOffensivePhase = false;

            UI_CombatLog.Instance?.LogMessage($"Combo token resolved! Starting a Bonus Offensive Roll Phase for {activePlayer.characterData.heroName}!", Color.black);
            yield return ShowNotification($"Combo token resolved! Starting a Bonus Offensive Roll Phase for {activePlayer.characterData.heroName}!", 1.5f);
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
        bool hasUpkeepEffects = false;

        if (activePlayer != null)
        {
            foreach (var status in activePlayer.activeStatuses)
            {
                if (status.data.primaryStatusEffectOutcomes != null && 
                    status.data.primaryStatusEffectOutcomes.Any(o => o.activationTrigger == StatusTrigger.OnTurnStart))
                {
                    hasUpkeepEffects = true;
                    break;
                }
            }
        }

        if (hasUpkeepEffects)
        {
            yield return ShowNotification($"Upkeep: Resolving Status Effects for {activePlayer.characterData.heroName}...", 2.0f);
            
            var statusesToProcess = activePlayer.activeStatuses.ToList();
            foreach (var status in statusesToProcess)
            {
                if (status.data.primaryStatusEffectOutcomes != null && 
                    status.data.primaryStatusEffectOutcomes.Any(o => o.activationTrigger == StatusTrigger.OnTurnStart))
                {
                    Debug.Log($"[Upkeep] Resolving {status.data.effectName} on Turn Start.");
                    if (StatusResolver.Instance != null) StatusResolver.Instance.ResolveTrigger(StatusTrigger.OnTurnStart, activePlayer, status.data);
                }
            }
            yield return new WaitForSeconds(1.0f);
        }
        else
        {
            UI_CombatLog.Instance?.LogMessage("No Status Effects to check.", Color.black);
            yield return ShowNotification("Upkeep: No Status Effects to check.", 1.5f);
        }

        SetPhase(TurnPhase.Income);
    }

    private IEnumerator ProcessIncomeRoutine()
    {
        if (isFirstTurnOfGame)
        {
            isFirstTurnOfGame = false;
            UI_CombatLog.Instance?.LogMessage($"Starting player ({activePlayer.characterData.heroName}) skipped the first Income Phase.", Color.black);
            yield return ShowNotification("Starting player skips the first Income Phase!", 2.5f);
        }
        else
        {
            activePlayer.ChangeCP(1);
            activePlayer.DrawCards(1);
            
            UI_CombatLog.Instance?.LogMessage($"Current CP: {activePlayer.currentCombatPoints}, Cards: {activePlayer.hand.Count}", Color.black);
            yield return ShowNotification("Income Phase: +1 CP, +1 Card", 2.5f);
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
                UI_CombatLog.Instance?.LogMessage($"Over limit cards: {overLimit}", Color.black);
                OnPhaseNotification?.Invoke($"Cleanup Phase: Please discard {overLimit} card(s)!");
                
                int currentCount = activePlayer.hand.Count;
                yield return new WaitUntil(() => activePlayer.hand.Count < currentCount);
            }
            NotifyPhase("");
        }
        else
        {
            UI_CombatLog.Instance?.LogMessage($"Cleanup Phase ended for {activePlayer.characterData.heroName}.", Color.black);
            yield return ShowNotification("Cleanup Phase: Hand size is within limit.", 1.5f);
        }

        EndTurn();
    }

    private IEnumerator SkipCombatAndAdvanceToMainPhase2(string skipReason)
    {
        OnCombatSkipped?.Invoke();

        UI_CombatLog.Instance?.LogMessage($"{skipReason}", Color.black);
        yield return ShowNotification(skipReason, 2.5f);
        
        ClearCombatIntent();
        SetPhase(TurnPhase.MainPhase2);
    }

    #endregion

    #region Combat Intent & Activation

    [Header("Combat State")]
    public bool hasActivatedAbilityThisPhase = false;
    public bool needsDefenseSelection = false;
    public bool canActivateDefensiveAbility = true;
    public bool isPerformingSpecialRoll = false;

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
    public float p1DamagePrevention = 0f;
    public float p2DamagePrevention = 0f;
    public bool turnDamageHalved = false;
    public float turnAttackModifier = 0f;
    public float turnCounterDamage = 0f;
    public bool isSpiderSenseSwapped = false;
    public bool turnAttackUndefendable = false;

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
        UI_CombatLog.Instance?.LogMessage($"{opponentPlayer.characterData.heroName} selected {defAbility.abilityName} as defense. Rolling {defAbility.diceToRoll} dice.", Color.black);
        ShowNotification($"Defense selected: {defAbility.abilityName}. Rolling {defAbility.diceToRoll} dice.", 1.5f);
        Debug.Log($"[BattleManager] Defense selected: {defAbility.abilityName}. Rolling {defAbility.diceToRoll} dice.");
        
        AIDataLogger.Instance?.LogPlayerAction(opponentPlayer, "ActivateDefense", defAbility.abilityName);
    }

    public void SetPendingOffensiveAbility(OffensiveAbilityData ability, int tierIndex)
    {
        pendingOffensiveAbility = ability;
        pendingOffensiveTierIndex = tierIndex;

        UI_CombatLog.Instance?.LogMessage($"{activePlayer.characterData.heroName} selected {ability.abilityName} as pending attack.", Color.black);
        ShowNotification($"Attack Ability selected: {ability.abilityName}.", 1.5f);
        Debug.Log($"[BattleManager] {activePlayer.characterData.heroName} selected {ability.abilityName} as pending attack.");
        
        AIDataLogger.Instance?.LogPlayerAction(activePlayer, "ActivateOffense", ability.abilityName);

        var activation = ability.activations[tierIndex];
        if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
        {
            StartCoroutine(PerformSecondaryRollsAndStoreRoutine(activation, ability.abilityName));
        }
        else
        {
                if (ActionStackManager.Instance != null) 
                {
                    ActionStackManager.Instance.ResetPriorityPasses();
                    ActionStackManager.Instance.PassPriority(false);
                }
        }
    }

    public void SetPendingDefensiveAbility(DefensiveAbilityData ability)
    {
        pendingDefensiveAbility = ability;

        UI_CombatLog.Instance?.LogMessage($"{opponentPlayer.characterData.heroName} selected {ability.abilityName} as pending defense.", Color.black);
        ShowNotification($"Defense Ability selected: {ability.abilityName}.", 1.5f);
        Debug.Log($"[BattleManager] {opponentPlayer.characterData.heroName} selected {ability.abilityName} as pending defense.");
        
        if (ActionStackManager.Instance != null) 
        {
            ActionStackManager.Instance.ResetPriorityPasses();
            ActionStackManager.Instance.PassPriority(false);
        }
    }

    private IEnumerator PerformSecondaryRollsAndStoreRoutine(OffensiveAbilityData.AttackActivation activation, string abilityName)
    {
        isPerformingSpecialRoll = true;
        pendingSecondaryRollResults.Clear();
        yield return ShowNotification($"Rolling for {abilityName} effect...", 1.0f);

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

        if (ActionStackManager.Instance != null) 
        {
            ActionStackManager.Instance.ResetPriorityPasses();
            ActionStackManager.Instance.PassPriority(false);
        }
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
                UI_CombatLog.Instance?.LogMessage($"Dice changed! Pending ability {pendingOffensiveAbility.abilityName} for {activePlayer.characterData.heroName} is no longer valid.", Color.black);
                ShowNotification($"Dice changed! Pending ability {pendingOffensiveAbility.abilityName} for {activePlayer.characterData.heroName} is no longer valid.", 1.5f);
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
            
            // execute instant effects (CP, Draw) immediately upon commiting
            if (AbilityResolver.Instance != null) AbilityResolver.Instance.ProcessInstantEffects(committedOffense);
            
            if (turnAttackUndefendable)
            {
                committedOffense.runtimeAttackType = DamageType.Undefendable;
                turnAttackUndefendable = false;

                Debug.Log($"[BattleManager] Card effect made this attack Undefendable!");
            }

            UI_CombatLog.Instance?.LogMessage($"Successfully committed {pendingOffensiveAbility.abilityName} for Resolution.", Color.black);
            Debug.Log($"[BattleManager] Committed {pendingOffensiveAbility.abilityName} for Resolution.");
        }
        else if (currentPhase == TurnPhase.DefensiveRollPhase && pendingDefensiveAbility != null)
        {
            committedDefense = new ActivateAbilityAction(opponentPlayer, pendingDefensiveAbility, -1);

            UI_CombatLog.Instance?.LogMessage($"Successfully committed {pendingDefensiveAbility.abilityName} for Resolution.", Color.black);
            Debug.Log($"[BattleManager] Committed {pendingDefensiveAbility.abilityName} for Resolution.");
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
        p1DamagePrevention = 0f;
        p2DamagePrevention = 0f;
        turnDamageHalved = false;
        turnAttackModifier = 0f;
        turnCounterDamage = 0f;
        isSpiderSenseSwapped = false;
        turnAttackUndefendable = false;

        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.ResetDice(0, 5);
        }
    }

    public void AddTurnPrevention(PlayerController player, float value)
    {
        if (player == player1) p1DamagePrevention += value;
        else if (player == player2) p2DamagePrevention += value;

        UI_CombatLog.Instance?.LogMessage($"Added {value} prevention to {player.characterData.heroName}.", Color.black);
        Debug.Log($"[BattleManager] Added {value} prevention to {player.characterData.heroName}.");
    }

    public float ConsumePrevention(PlayerController player, float damageAmount)
    {
        float preventionAvailable = (player == player1) ? p1DamagePrevention : p2DamagePrevention;
        float preventionUsed = Mathf.Min(preventionAvailable, damageAmount);
        
        if (player == player1) p1DamagePrevention -= preventionUsed;
        else if (player == player2) p2DamagePrevention -= preventionUsed;
        
        return preventionUsed;
    }

    public void HalveTurnDamage()
    {
        turnDamageHalved = true;
        
        UI_CombatLog.Instance?.LogMessage($"Incoming damage for {opponentPlayer.characterData.heroName} will be halved this turn.", Color.black);
        Debug.Log("[BattleManager] Ability activated: Incoming damage will be halved this turn.");
    }

    public bool GetAndClearTurnDamageHalved()
    {
        bool val = turnDamageHalved;
        turnDamageHalved = false;
        return val;
    }

    public void AddTurnAttackModifier(float value)
    {
        turnAttackModifier += value;

        UI_CombatLog.Instance?.LogMessage($"{activePlayer.characterData.heroName} added {value} as attack modifier. Total additional damage: {turnAttackModifier}", Color.black);
        Debug.Log($"[BattleManager] Added {value} to turn attack modifier. Total: {turnAttackModifier}");
    }

    public float GetAndClearTurnAttackModifier()
    {
        float value = turnAttackModifier;
        turnAttackModifier = 0f;
        return value;
    }

    public void AddTurnCounterDamage(float value)
    {
        turnCounterDamage += value;

        UI_CombatLog.Instance?.LogMessage($"{activePlayer.characterData.heroName} added {value} as counterattack damage. Total counterattack damage: {turnAttackModifier}", Color.black);
        Debug.Log($"[BattleManager] Added {value} to turn counter damage. Total: {turnCounterDamage}");
    }

    public float GetAndClearTurnCounterDamage()
    {
        float value = turnCounterDamage;
        turnCounterDamage = 0f;
        return value;
    }
    #endregion

}