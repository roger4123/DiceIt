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

    public event Action<TurnPhase> OnPhaseChanged;

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

        OnPhaseChanged?.Invoke(currentPhase);

        switch (currentPhase)
        {
            case TurnPhase.Upkeep:
                ProcessUpkeep();
                break;

            case TurnPhase.Income:
                ProcessIncome();
                break;

            case TurnPhase.MainPhase1:
                // UI Input
                break;

            case TurnPhase.OffensiveRollPhase:
                if (DiceManager.Instance != null)
                {
                    DiceManager.Instance.ResetDice();
                }
                break;

            case TurnPhase.DefensiveRollPhase:
                break;
            
            case TurnPhase.Resolution:
                ProcessResolution();
                break;

            case TurnPhase.MainPhase2:
                break;

            case TurnPhase.Cleanup:
                ProcessCleanup();
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

    private void ProcessUpkeep()
    {
        // idee: iterare prin Status Effects active si check for OnTurnStart types
        // momentan e skippable
        SetPhase(TurnPhase.Income);
    }

    private void ProcessIncome()
    {
        // exceptie: first turn of the game (first Active Player)
        activePlayer.ChangeCP(1);
        activePlayer.DrawCards(1);
        
        SetPhase(TurnPhase.MainPhase1);
    }

    private void ProcessResolution()
    {
        // finalizare calcule dmg
        SetPhase(TurnPhase.MainPhase2);
    }

    private void ProcessCleanup()
    {
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
}