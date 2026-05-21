using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class UI_DiceFaceSelector : MonoBehaviour
{
    public static UI_DiceFaceSelector Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    public Button closeButton;
    public Transform buttonsContainer;
    public GameObject diceButtonPrefab;

    private Action<int> onFaceSelected;
    private List<GameObject> spawnedButtons = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        if (closeButton != null) closeButton.onClick.AddListener(CancelSelection);
        Hide();
    }

    public void Show(PlayerController player, List<int> validValues, Action<int> callback)
    {
        onFaceSelected = callback;

        foreach (var btn in spawnedButtons) Destroy(btn);
        spawnedButtons.Clear();

        DiceKeyData key = player.characterData.diceKey;

        for (int i = 1; i <= 6; i++)
        {
            GameObject obj = Instantiate(diceButtonPrefab, buttonsContainer);
            spawnedButtons.Add(obj);

            UI_DiceDisplay display = obj.GetComponent<UI_DiceDisplay>();
            Button btn = obj.GetComponent<Button>();

            if (display != null && key != null)
            {
                DiceSymbol symbol = key.GetSymbolForValue(i);
                display.SetupPlayDie(i, symbol, key.dieColor, key.numberColor);
            }

            if (btn != null)
            {
                int faceValue = i;
                if (validValues.Contains(i))
                {
                    btn.interactable = true;
                    btn.onClick.AddListener(() => SelectFace(faceValue));
                }
                else
                {
                    btn.interactable = false;
                    CanvasGroup cg = obj.GetComponent<CanvasGroup>();
                    if (cg == null) cg = obj.AddComponent<CanvasGroup>();
                    cg.alpha = 0.5f;
                }
            }
        }

        modalPanel.SetActive(true);
        transform.SetAsLastSibling();
    }

    private void SelectFace(int value)
    {
        Hide();
        onFaceSelected?.Invoke(value);
    }

    private void CancelSelection()
    {
        Hide();
        onFaceSelected?.Invoke(-1);
    }

    public void Hide()
    {
        if (modalPanel != null) modalPanel.SetActive(false);
    }
}