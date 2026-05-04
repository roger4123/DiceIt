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
    public TextMeshProUGUI activateButtonText;

    private bool isConfirming = false;
    private BaseAbilityData currentAbility;
    private PlayerController currentOwner;
    private ColorBlock defaultButtonColors;

    private void Awake()
    {
        Instance = this;

        if (activateButtonComponent != null)
        {
            defaultButtonColors = activateButtonComponent.colors;
            activateButtonComponent.onClick.AddListener(OnActivateClicked);
        }

        Hide();
    }

    public void Show(BaseAbilityData data, PlayerController slotOwner)
    {
        if (data == null) return;

        currentOwner = slotOwner;
        currentAbility = data;
        titleText.text = data.abilityName;
        descriptionText.text = data.description;

        isConfirming = false;
        if (activateButtonText != null)
        {
            activateButtonText.text = "ACTIVATE";
            activateButtonComponent.colors = defaultButtonColors; // Reseteaza la verdele initial
        }


        foreach (Transform child in requirementsContainer)
        {
            Destroy(child.gameObject);
        }

        Color characterDieColor = slotOwner.characterData.diceKey.dieColor;
        bool canActivate = false;

        if (data is OffensiveAbilityData oad && oad.activations != null && oad.activations.Count > 0)
        {
            List<int> currentDice = DiceManager.Instance.GetCurrentDiceValues();
            List<int> validTiers = AbilityMatcher.GetValidActivations(oad, currentDice, slotOwner.characterData.diceKey);

            canActivate = validTiers.Count > 0;

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
                    if (activation.type == RequirementType.SmallStraight)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            GameObject dieObj = Instantiate(dicePrefab, blockDiceContainer);
                            dieObj.GetComponent<UI_DiceDisplay>().SetupBlankDie(Color.gray);

                            float defaultSize = dieObj.GetComponent<RectTransform>().sizeDelta.x;
                            float scaleMultiplier = 1.0f - (3 - i) * 0.1f; 
                            float scaledSize = defaultSize * scaleMultiplier;

                            LayoutElement layoutElement = dieObj.GetComponent<LayoutElement>();
                            if (layoutElement != null)
                            {
                                layoutElement.preferredWidth = scaledSize;
                                layoutElement.preferredHeight = scaledSize;
                                layoutElement.minWidth = scaledSize;
                                layoutElement.minHeight = scaledSize;
                            }
                            else
                            {
                                dieObj.GetComponent<RectTransform>().sizeDelta = new Vector2(scaledSize, scaledSize);     
                            }
                         }
                    }
                    else if (activation.type == RequirementType.LargeStraight)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            GameObject dieObj = Instantiate(dicePrefab, blockDiceContainer);
                            dieObj.GetComponent<UI_DiceDisplay>().SetupBlankDie(Color.gray);

                            float defaultSize = dieObj.GetComponent<RectTransform>().sizeDelta.x;
                            float scaleMultiplier = 1.0f - (4 - i) * 0.1f; 
                            float scaledSize = defaultSize * scaleMultiplier;

                            LayoutElement layoutElement = dieObj.GetComponent<LayoutElement>();
                            if (layoutElement != null)
                            {
                                layoutElement.preferredWidth = scaledSize;
                                layoutElement.preferredHeight = scaledSize;
                                layoutElement.minWidth = scaledSize;
                                layoutElement.minHeight = scaledSize;
                            }
                            else
                            {
                                dieObj.GetComponent<RectTransform>().sizeDelta = new Vector2(scaledSize, scaledSize);     
                            }
                        }
                    }
                    else
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
        }
        else if (data is DefensiveAbilityData dad)
        {
            descriptionText.gameObject.SetActive(true);
            GameObject blockObj = Instantiate(activationBlockPrefab, requirementsContainer);
            Transform blockDiceContainer = blockObj.transform.Find("DiceContainer");
            Transform textTransform = blockObj.transform.Find("DescriptionText");

            if (textTransform != null)
            {
                textTransform.gameObject.SetActive(false);
                textTransform.GetComponent<TextMeshProUGUI>().text = $"Roll {dad.diceToRoll}";
            } 

            if (blockDiceContainer != null)
            {
                for (int i = 0; i < dad.diceToRoll; i++)
                {
                    GameObject dieObj = Instantiate(dicePrefab, blockDiceContainer);
                    dieObj.GetComponent<UI_DiceDisplay>().SetupBlankDie(Color.green); 
                }
            }

            canActivate = DiceManager.Instance.hasRolledThisPhase;
        }
        else descriptionText.gameObject.SetActive(true);

        bool isOffensivePhase = BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase;
        bool isDefensivePhase = BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase;
        
        bool canUseOffensive = isOffensivePhase && (BattleManager.Instance.activePlayer == currentOwner) && (data is OffensiveAbilityData);
        bool canUseDefensive = isDefensivePhase && (BattleManager.Instance.opponentPlayer == currentOwner) && (data is DefensiveAbilityData);
        
        // Regula 1: If you successfully activate an ability, you can't activate another one in the same turn
        if (BattleManager.Instance.hasActivatedAbilityThisPhase)
        {
            canUseOffensive = false;
            canUseDefensive = false;
        }

        // Regula 2: Only the selected Defensive Ability is available for activation
        if (isDefensivePhase && !BattleManager.Instance.needsDefenseSelection && BattleManager.Instance.pendingDefenseSelection != null)
        {
            if (data != BattleManager.Instance.pendingDefenseSelection) canUseDefensive = false;
        }

        bool isSelectingDefense = canUseDefensive && BattleManager.Instance.needsDefenseSelection;

        if (isSelectingDefense)
        {
            activateButton.SetActive(true);
            activateButtonComponent.interactable = true;
            if (activateButtonText != null) activateButtonText.text = "SELECT DEFENSE";
        }
        else
        {
            activateButton.SetActive(canUseOffensive || canUseDefensive);
            if (canUseOffensive || canUseDefensive)
            {
                activateButtonComponent.interactable = canActivate; //  hasRolledThisPhase == true
                if (activateButtonText != null) activateButtonText.text = "ACTIVATE";
            }
        }

        modalPanel.SetActive(true);
    }

    private void OnActivateClicked()
    {
        // "selection" phase for Defensive Ability 
        if (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase && BattleManager.Instance.needsDefenseSelection)
        {
            BattleManager.Instance.SelectDefense((DefensiveAbilityData)currentAbility);
            Hide();
            return; // don't put the action on stack yet
        }

        if (!isConfirming)
        {
            isConfirming = true;
            if (activateButtonText != null)
            {
                activateButtonText.text = "ARE YOU SURE?";
            }

            ColorBlock cb = activateButtonComponent.colors;
            cb.normalColor = new Color(1f, 0.98f, 0.0f, 1f);
            cb.highlightedColor = new Color(0.78f, 0.72f, 0f, 1f);
            activateButtonComponent.colors = cb;

            Debug.Log("Waiting for confirmation...");
        }
        else
        {
            Debug.Log($"==> Sending abilitiy to Stack: {currentAbility.abilityName}!");

            // the player can insert the ability in the stack only if it has prio in that given moment
            if (ActionStackManager.Instance == null)
            {
                Debug.LogError("[UI_AbilityModal] ActionStackManager is missing from the scene! Please add it to a GameObject.");
            }
            else if (ActionStackManager.Instance.playerWithPriority == currentOwner)
            {
                ActivateAbilityAction action = new ActivateAbilityAction(currentOwner, currentAbility);
                ActionStackManager.Instance.AddActionToStack(action);
                BattleManager.Instance.MarkAbilityActivated();
            }
            else
            {
                Debug.LogWarning($"Can't activate the ability! {currentOwner.characterData.heroName} doesn't have priority.");
            }

            Hide();
            
            UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
        }
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}
