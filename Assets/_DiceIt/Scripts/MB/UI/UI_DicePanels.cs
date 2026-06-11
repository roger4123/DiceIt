using System.Collections.Generic;
using UnityEngine;

public class UI_DicePanels : MonoBehaviour
{
    [Header("UI References")]
    public List<UI_DiceDisplay> p1DiceIcons = new List<UI_DiceDisplay>(5);
    public List<UI_DiceDisplay> p2DiceIcons = new List<UI_DiceDisplay>(5);
    
    [Header("Player References")]
    public PlayerController player1;
    public PlayerController player2;

    private void Start()
    {
        for (int i = 0; i < p1DiceIcons.Count; i++)
        {
            p1DiceIcons[i].SetIndex(i);
            p1DiceIcons[i].SetupOwner(player1);
        }
        for (int i = 0; i < p2DiceIcons.Count; i++)
        {
            p2DiceIcons[i].SetIndex(i);
            p2DiceIcons[i].SetupOwner(player2);
        }

        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged += UpdateDiceVisuals;
        }
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += HandlePhaseChange;
        }

        ResetAllDiceVisuals();
    }

    private void OnDestroy()
    {
        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged -= UpdateDiceVisuals;
        }
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= HandlePhaseChange;
        }
    }

    private void UpdateDiceVisuals(List<DiceManager.DieState> currentDice, int rollsLeft)
    {
        PlayerController rollingPlayer = (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase) 
                                         ? BattleManager.Instance.opponentPlayer 
                                         : BattleManager.Instance.activePlayer;

        if (rollingPlayer == null || rollingPlayer.characterData == null) return;

        DiceKeyData currentKey = rollingPlayer.characterData.diceKey;

        List<UI_DiceDisplay> activeUIList = (rollingPlayer == BattleManager.Instance.player1) ? p1DiceIcons : p2DiceIcons;

        for (int i = 0; i < currentDice.Count; i++)
        {
            if (!currentDice[i].isActive)
            {
                activeUIList[i].gameObject.SetActive(false);
                continue;
            }
            
            activeUIList[i].gameObject.SetActive(true);
            int val = currentDice[i].currentValue;
            if (val == 0)
            {
                activeUIList[i].SetupBlankDie(Color.gray);
            }
            else
            {
                DiceSymbol symbolData = currentKey.GetSymbolForValue(val);
                activeUIList[i].SetupPlayDie(val, symbolData, currentKey.dieColor, currentKey.numberColor);
            }

            activeUIList[i].SetLockVisual(currentDice[i].isLocked);
        }

    }

    private void HandlePhaseChange(TurnPhase newPhase)
    {
        // if we enter any phase that is NOT a roll phase, blank out all dice visuals.
        if (newPhase != TurnPhase.OffensiveRollPhase && newPhase != TurnPhase.DefensiveRollPhase)
        {
            ResetAllDiceVisuals();
        }
    }

    private void ResetAllDiceVisuals()
    {
        foreach (var dieIcon in p1DiceIcons)
        {
            dieIcon.gameObject.SetActive(true);
            dieIcon.SetupBlankDie(Color.gray);
            dieIcon.SetLockVisual(false);
        }
        
        foreach (var dieIcon in p2DiceIcons)
        {
            dieIcon.gameObject.SetActive(true);
            dieIcon.SetupBlankDie(Color.gray);
            dieIcon.SetLockVisual(false);
        }
    }
}