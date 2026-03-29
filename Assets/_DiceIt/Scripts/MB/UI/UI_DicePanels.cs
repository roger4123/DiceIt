using System.Collections.Generic;
using UnityEngine;

// Acest script va fi pus pe Canvas, pe parintele care contine zarurile vizuale
public class UI_DicePanels : MonoBehaviour
{
    [Header("UI References")]
    public List<UI_DiceDisplay> p1DiceIcons = new List<UI_DiceDisplay>(5);
    public List<UI_DiceDisplay> p2DiceIcons = new List<UI_DiceDisplay>(5);

    private void Start()
    {
        for (int i = 0; i < p1DiceIcons.Count; i++) p1DiceIcons[i].SetIndex(i);
        for (int i = 0; i < p2DiceIcons.Count; i++) p2DiceIcons[i].SetIndex(i);

        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged += UpdateDiceVisuals;
        }
    }

    private void OnDestroy()
    {
        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged -= UpdateDiceVisuals;
        }
    }

    private void UpdateDiceVisuals(List<DiceManager.DieState> currentDice, int rollsLeft)
    {
        PlayerController activePlayer = BattleManager.Instance.activePlayer;
        if (activePlayer == null || activePlayer.characterData == null) return;

        DiceKeyData currentKey = activePlayer.characterData.diceKey;

        List<UI_DiceDisplay> activeUIList = (activePlayer == BattleManager.Instance.player1) ? p1DiceIcons : p2DiceIcons;

        for (int i = 0; i < currentDice.Count; i++)
        {
            int val = currentDice[i].currentValue;
            DiceSymbol symbolData = currentKey.GetSymbolForValue(val);
            activeUIList[i].SetupPlayDie(val, symbolData, currentKey.dieColor, currentKey.numberColor);
            activeUIList[i].SetLockVisual(currentDice[i].isLocked);
        }

        // un eventual buton de RollsLeft? pe ecran?
    }
}