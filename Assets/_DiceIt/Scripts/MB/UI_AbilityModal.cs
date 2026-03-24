using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class UI_AbilityModal : MonoBehaviour
{
    public static UI_AbilityModal Instance; // Singleton

    [Header("UI References")]
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public GameObject modalPanel;
    public Transform requirementsContainer;
    public GameObject dicePrefab;

    [Header("Buttons")]
    public GameObject activateButton;
    public Button activateButtonComponent;

    private void Awake()
    {
        Instance = this;
        Hide();
    }

    public void Show(BaseAbilityData data, PlayerController slotOwner)
    {
        if (data == null) return;

        titleText.text = data.abilityName;
        descriptionText.text = data.description;

        foreach (Transform child in requirementsContainer)
        {
            Destroy(child.gameObject);
        }

        List<SymbolRequirement> reqs = data.GetActivationSymbols();
        if (reqs != null)
        {
            Color characterDieColor = slotOwner.characterData.diceKey.dieColor;

            foreach (var req in reqs)
            {
                for (int i = 0; i < req.count; i++) 
                {
                    GameObject dieObj = Instantiate(dicePrefab, requirementsContainer);
                    UI_DiceDisplay dieScript = dieObj.GetComponent<UI_DiceDisplay>();
                    
                    dieScript.SetupRequirementDie(req.symbol, characterDieColor);
                }
            }
        }

        bool isMyTurn = (BattleManager.Instance.activePlayer == slotOwner);
        activateButton.SetActive(isMyTurn);

        if (isMyTurn)
        {
            // + dice requirements check
            activateButtonComponent.interactable = true; 
        }

        modalPanel.SetActive(true);
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}
