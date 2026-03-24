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

    [Header("UI References")]
    // public TextMeshProUGUI p1DiceDisplayText;
    // public TextMeshProUGUI p2DiceDisplayText;
    public List<UI_DiceDisplay> p1DiceIcons = new List<UI_DiceDisplay>(5);
    public List<UI_DiceDisplay> p2DiceIcons = new List<UI_DiceDisplay>(5);

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

            // UI index
            if(i < p1DiceIcons.Count) p1DiceIcons[i].SetIndex(i);
            if(i < p2DiceIcons.Count) p2DiceIcons[i].SetIndex(i);
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
        
        UpdateDiceUI();
    }


    public void ToggleLock(int index)
    {
        if (!hasRolledThisPhase) return;

        if (index >= 0 && index < dice.Count)
        {
            dice[index].isLocked = !dice[index].isLocked;
            UpdateDiceUI();
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
        PlayerController activePlayer = BattleManager.Instance.activePlayer;
        if (activePlayer == null || activePlayer.characterData == null) return;

        DiceKeyData currentKey = activePlayer.characterData.diceKey;

        List<UI_DiceDisplay> activeUIList = (activePlayer == BattleManager.Instance.player1) ? p1DiceIcons : p2DiceIcons;

        for (int i = 0; i < dice.Count; i++)
        {
            int val = dice[i].currentValue;
            DiceSymbol symbolData = currentKey.GetSymbolForValue(val);
            
            // send the data to the prefab's script
            activeUIList[i].SetupPlayDie(val, symbolData, currentKey.dieColor, currentKey.numberColor);
            
            // locked dice
            activeUIList[i].SetLockVisual(dice[i].isLocked);
        }
    }
}

