using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

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
    
    [Header("State")]
    public PlayerController activePlayer;
    public PlayerController opponentPlayer;
    public TurnPhase currentPhase;
    public bool hasActivatedAbilityThisPhase = false;

    [Header("Defense Selection")]
    public DefensiveAbilityData pendingDefenseSelection;
    public bool needsDefenseSelection = false;

    public event Action<TurnPhase> OnPhaseChanged;
    public event Action<string> OnPhaseNotification;
    public event Action OnDefenseSelected;
    public event Action OnAbilityActivated;

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
        Debug.Log($"Starting Phase: {currentPhase} for {activePlayer.characterData.heroName}");        

        // reset state vars before launching OnPhaseChanged
        if (currentPhase == TurnPhase.OffensiveRollPhase || currentPhase == TurnPhase.DefensiveRollPhase)
        {
            hasActivatedAbilityThisPhase = false;
            pendingDefenseSelection = null;
            needsDefenseSelection = false;
        }

        // Global rule: Disable dice interaction unless it's a roll phase.
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
                // TODO: checking Normal dmg (momentan consideram Normal)
                bool isIncomingAttackNormal = true; 

                if (DiceManager.Instance != null)
                {
                    if (isIncomingAttackNormal && opponentPlayer.activeDefensiveAbilities.Count > 0)
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
                    else DiceManager.Instance.ResetDice(1, 0);
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

    #region Phase Logic

    public void AdvancePhase()
    {
        switch (currentPhase)
        {
            case TurnPhase.MainPhase1:
                SetPhase(TurnPhase.OffensiveRollPhase);
                break;

            case TurnPhase.OffensiveRollPhase:
                SetPhase(TurnPhase.DefensiveRollPhase);
                break;

            case TurnPhase.DefensiveRollPhase:
                SetPhase(TurnPhase.Resolution);
                break;

            case TurnPhase.MainPhase2:
                SetPhase(TurnPhase.Cleanup);
                break;

            default:
                Debug.Log("AdvancePhase was called in an automatic phase. Ignoring the action.");
                break;
        }
    }

    private IEnumerator ProcessUpkeepRoutine()
    {
        OnPhaseNotification?.Invoke("Upkeep: No Status Effects to check.");
        yield return new WaitForSeconds(2.5f);

        // idee: iterare prin Status Effects active si check for OnTurnStart types
        // momentan e skippable
        SetPhase(TurnPhase.Income);
    }

    private IEnumerator ProcessIncomeRoutine()
    {
        OnPhaseNotification?.Invoke("Income: +1 CP, +1 Card");
        yield return new WaitForSeconds(2.5f);

        // exceptie: first turn of the game (first Active Player)
        activePlayer.ChangeCP(1);
        activePlayer.DrawCards(1);
        
        SetPhase(TurnPhase.MainPhase1);
    }

    private IEnumerator ProcessResolutionRoutine()
    {
        OnPhaseNotification?.Invoke("Resolution Phase: Calculating Damage...");
        yield return new WaitForSeconds(2.5f);

        // finalizare calcule dmg
        SetPhase(TurnPhase.MainPhase2);
    }

    private IEnumerator ProcessCleanupRoutine()
    {
        OnPhaseNotification?.Invoke("Cleanup Phase: Discarding excess cards...");
        yield return new WaitForSeconds(2.5f);

        while (activePlayer.hand.Count > 6)
        {
            // UI Input pentru cartea selectata
            // momentan, discard prima carte automat
            activePlayer.DiscardCard(activePlayer.hand[0]);
        }

        EndTurn();
    }

    public void EndTurn()
    {
        PlayerController temp = activePlayer;
        activePlayer = opponentPlayer;
        opponentPlayer = temp;

        StartNewTurn();
    }

    #endregion

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

    public void MarkAbilityActivated()
    {
        hasActivatedAbilityThisPhase = true;
        OnAbilityActivated?.Invoke();
    }
}