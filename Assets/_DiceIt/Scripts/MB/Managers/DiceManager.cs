using UnityEngine;
using System;
using System.Collections.Generic;
using TMPro;

public class DiceManager : MonoBehaviour
{
    // Singleton pattern for accessing the manager from anywhere
    public static DiceManager Instance;


    [System.Serializable]
    public class DieState
    {
        public int currentValue = 1;
        public bool isLocked = false;   // pentru rerolls
        
        public void Roll()
        {
            if (!isLocked)
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


    public void ToggleLock(int index)
    {
        if (!hasRolledThisPhase) return;

        if (index >= 0 && index < dice.Count)
        {
            dice[index].isLocked = !dice[index].isLocked;
            BroadcastState();
        }
    }

    public void ResetDice()
    {
        rollsLeft = 3;
        hasRolledThisPhase = false;
        foreach (var die in dice)
        {
            die.isLocked = false;
            die.currentValue = 1;
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
}

