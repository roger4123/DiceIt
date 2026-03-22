using UnityEngine;
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
    public static BattleManager Instance;

    [Header("Players")]
    public PlayerController player1;
    public PlayerController player2;
    
    [Header("State")]
    public PlayerController activePlayer;
    public PlayerController opponentPlayer;
    public TurnPhase currentPhase;

    private void Awake()
    {
        // Singleton pattern for accessing the manager from anywhere
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
        Debug.Log($"==> Current Phase: {currentPhase}");

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
            case TurnPhase.OffensiveRoll:
                // DiceManager
                // ProcessDice();
                break;
            case TurnPhase.Resolution:
                ProcessResolution();
                break;
            case TurnPhase.Cleanup:
                ProcessCleanup();
                break;
        }
    }

    #region Phase Logic

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

    public void EndMainPhase1()
    {
        if (currentPhase == TurnPhase.MainPhase1)
            SetPhase(TurnPhase.OffensiveRoll);
    }

    private void ProcessResolution()
    {
        // finalizare calcule dmg
        SetPhase(TurnPhase.MainPhase2);
    }

    public void EndMainPhase2()
    {
        if (currentPhase == TurnPhase.MainPhase2)
            SetPhase(TurnPhase.Cleanup);
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