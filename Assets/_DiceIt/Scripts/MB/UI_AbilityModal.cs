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
    public GameObject activationBlockPrefab;
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

        Color characterDieColor = slotOwner.characterData.diceKey.dieColor;

        if (data is OffensiveAbilityData oad && oad.activations != null && oad.activations.Count > 0)
        {
            if (oad.activations.Count > 1)
            {
                descriptionText.gameObject.SetActive(false);
            }
            else
            {
                descriptionText.gameObject.SetActive(true);
            }

            foreach (var activation in oad.activations)
            {
                GameObject blockObj = Instantiate(activationBlockPrefab, requirementsContainer);

                Transform blockDiceContainer = blockObj.transform.Find("DiceContainer");
                TextMeshProUGUI blockText = blockObj.transform.Find("DescriptionText").GetComponent<TextMeshProUGUI>();

                if (blockText != null) 
                {
                    if (oad.activations.Count == 1)
                    {
                        blockText.gameObject.SetActive(false);
                    }
                    else
                    {
                        blockText.gameObject.SetActive(true);
                        blockText.text = activation.label;
                    }
                }

                if (blockDiceContainer != null)
                {
                    foreach (var req in activation.symbolsNeeded)
                    {
                        for (int i = 0; i < req.count; i++)
                        {
                            GameObject dieObj = Instantiate(dicePrefab, blockDiceContainer);
                            dieObj.GetComponent<UI_DiceDisplay>().SetupRequirementDie(req.symbol, characterDieColor);
                        }
                    }
                }
            }
        }
        else
        {
            descriptionText.gameObject.SetActive(true);

            List<SymbolRequirement> reqs = data.GetActivationSymbols();
            
            if (reqs != null && reqs.Count > 0)
            {
                GameObject blockObj = Instantiate(activationBlockPrefab, requirementsContainer);
                Transform blockDiceContainer = blockObj.transform.Find("DiceContainer");
                Transform textTransform = blockObj.transform.Find("DescriptionText");
                textTransform?.gameObject.SetActive(false);

                if (blockDiceContainer != null)
                {
                    foreach (var req in reqs)
                    {
                        for (int i = 0; i < req.count; i++)
                        {
                            GameObject dieObj = Instantiate(dicePrefab, blockDiceContainer);
                            dieObj.GetComponent<UI_DiceDisplay>().SetupRequirementDie(req.symbol, characterDieColor);
                        }
                    }
                }
            }
        }

        Debug.Log($"Active Player: {BattleManager.Instance.activePlayer.name} | Slot Owner: {slotOwner.name}");
        bool isMyTurn = (BattleManager.Instance.activePlayer == slotOwner);
        activateButton.SetActive(isMyTurn);

        if (isMyTurn)
        {
            // + dice requirements check
            activateButtonComponent.interactable = false;  // de schimbat in true
        }

        modalPanel.SetActive(true);
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}
