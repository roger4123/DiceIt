using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;

public enum DiceInteractionState
{
    Disabled,           // No one can interact with any dice.
    PlayerLocking,      // The current rolling player can lock/unlock their own dice.
    SelectingDice       // A player selects a die for a card effect
}

public class DiceManager : MonoBehaviour
{
    // Singleton pattern for accessing the manager from anywhere
    public static DiceManager Instance;


    [System.Serializable]
    public class DieState
    {
        public int currentValue = 0;
        public bool isLocked = false;   // pentru rerolls
        public bool isActive = true;    // marcheaza daca zarul e utilizabil
        
        public void Roll()
        {
            if (isActive && !isLocked)
            {
                currentValue = UnityEngine.Random.Range(1, 7);
            }
        }
    }

    public event Action<List<DieState>, int> OnDiceStateChanged;

    [Header("Dice State")]
    public List<DieState> dice = new List<DieState>(5);
    public int rollsLeft = 3;
    public bool hasRolledThisPhase = false;
    public DiceInteractionState CurrentInteractionState { get; private set; } = DiceInteractionState.Disabled;

    private Action<int, PlayerController> pendingDieSelectionCallback;
    private PlayerController validTargetPlayerForSelection;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        
        dice.Clear();
        for (int i = 0; i < 5; i++)
        {
            dice.Add(new DieState());
        }
    }

    public void RollDice()
    {
        if (rollsLeft <= 0)
        {
            Debug.Log("==> No more Roll Attempts left!");
            return;
        }

        hasRolledThisPhase = true;

        foreach (var die in dice)
        {
            die.Roll();
        }

        rollsLeft--;
        Debug.Log($"==> Rolled successfully! Remaining Roll Attemtps: {rollsLeft}");
        
        BroadcastState();
    }


    public void RequestDieSelection(PlayerController targetPlayer, Action<int, PlayerController> callback)
    {
        validTargetPlayerForSelection = targetPlayer;
        pendingDieSelectionCallback = callback;
        SetInteractionState(DiceInteractionState.SelectingDice);
        Debug.Log($"[DiceManager] Waiting for player to select a die...");
    }

    public void OnDieClicked(int index, PlayerController clickedOwner)
    {
        // Rule 1: If interaction is disabled globally, do nothing.
        if (CurrentInteractionState == DiceInteractionState.Disabled) return;
        
        // Rule 2: You can't lock dice before the first roll.
        if (!hasRolledThisPhase) return; 
        if (clickedOwner == null) return;

        // Rule 3: Handle standard player locking.
        if (CurrentInteractionState == DiceInteractionState.PlayerLocking)
        {
            PlayerController rightfulLocker = (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase)
                                              ? BattleManager.Instance.opponentPlayer
                                              : BattleManager.Instance.activePlayer;
    
            if (clickedOwner == rightfulLocker)
            {
                PerformToggleLock(index);
            }
            else
            {
                Debug.LogWarning($"[DiceManager] {clickedOwner.characterData.heroName} tried to lock a die, but it's {rightfulLocker.characterData.heroName}'s turn to do so.");
            }
        }
        // Rule 4: Handle selection targeting from cards/effects.
        else if (CurrentInteractionState == DiceInteractionState.SelectingDice)
        {
            if (validTargetPlayerForSelection == null || clickedOwner == validTargetPlayerForSelection)
            {
                var callback = pendingDieSelectionCallback;
                pendingDieSelectionCallback = null;
                validTargetPlayerForSelection = null;
                
                callback?.Invoke(index, clickedOwner);
            }
            else Debug.LogWarning($"[DiceManager] You must select a valid die!");
        }
    }

    private void PerformToggleLock(int index)
    {
        if (index >= 0 && index < dice.Count && dice[index].isActive)
        {
            dice[index].isLocked = !dice[index].isLocked;
            BroadcastState();
        }
    }

    public void SetDieValue(int index, int newValue)
    {
        if (index >= 0 && index < dice.Count)
        {
            dice[index].currentValue = newValue;
            BroadcastState();
        }
    }

    public void ForceRerollDie(int index)
    {
        if (index >= 0 && index < dice.Count)
        {
            dice[index].currentValue = UnityEngine.Random.Range(1, 7);
            BroadcastState();
        }
    }

    public void ResetDice( int rollsAllowed = 3, int activeDiceCount = 5)
    {
        rollsLeft = rollsAllowed;
        hasRolledThisPhase = false;
        for (int i = 0; i < dice.Count; i++)
        {
            dice[i].isLocked = false;
            dice[i].currentValue = 0;
            dice[i].isActive = (i < activeDiceCount); // diceToRoll
        }
        
        BroadcastState();
    }

    public List<int> GetCurrentDiceValues()
    {
        List<int> values = new List<int>();
        foreach (var die in dice)
        {
            values.Add(die.currentValue);
        }
        return values;  // list pentru comparare cu Ability Requirements
    }

    private void BroadcastState()
    {
        OnDiceStateChanged?.Invoke(dice, rollsLeft);
    }

    public void SetInteractionState(DiceInteractionState newState)
    {
        CurrentInteractionState = newState;
        Debug.Log($"[DiceManager] Interaction state set to: {newState}");
    }
}
