using UnityEngine;
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
                currentValue = Random.Range(1, 7);
            }
        }
    }

    [Header("UI Reference")]
    public TextMeshProUGUI diceDisplayText;

    [Header("Dice State")]
    public List<DieState> dice = new List<DieState>(5);
    public int rollsLeft = 3;

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

        foreach (var die in dice)
        {
            die.Roll();
        }

        rollsLeft--;
        Debug.Log($"==> Rolled successfully! Remaining Roll Attemtps: {rollsLeft}");
        
        // + transmitere semnal catre UI pentru update
        UpdateDiceUI();
    }


    public void ToggleLock(int index)
    {
        if (index >= 0 && index < dice.Count)
        {
            dice[index].isLocked = !dice[index].isLocked;
        }
    }

    public void ResetDice()
    {
        rollsLeft = 3;
        foreach (var die in dice)
        {
            die.isLocked = false;
            die.currentValue = 1;
        }
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

    public void UpdateDiceUI()
    {
        if (diceDisplayText == null) return;

        string result = "";
        for (int i = 0; i < dice.Count; i++)
        {
            result += dice[i].currentValue.ToString();
            if (i < dice.Count - 1) result += " | ";
        }
        
        diceDisplayText.text = result;
    }
}

