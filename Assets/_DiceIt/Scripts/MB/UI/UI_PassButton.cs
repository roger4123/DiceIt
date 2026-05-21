using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PassButton : MonoBehaviour
{
    [Header("UI References")]
    public Button passButtonComponent;
    public TextMeshProUGUI passButtonText;

    private void Start()
    {
        if (passButtonComponent != null)
        {
            passButtonComponent.onClick.AddListener(OnPassButtonClicked);
        }

        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += UpdateButtonState;
            BattleManager.Instance.OnCombatSkipped += DisableButtonTemporarily;
            UpdateButtonState(BattleManager.Instance.currentPhase);
        }
        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.OnPriorityChanged += UpdatePriorityColor;
        }
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= UpdateButtonState;
            BattleManager.Instance.OnCombatSkipped -= DisableButtonTemporarily;
        }
        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.OnPriorityChanged -= UpdatePriorityColor;
        }
    }

    private void UpdatePriorityColor(PlayerController playerWithPrio)
    {
        if (playerWithPrio == null || passButtonComponent == null) return;

        Color playerColor = playerWithPrio.characterData.diceKey.dieColor;
        
        ColorBlock cb = passButtonComponent.colors;
        cb.normalColor = playerColor;
        cb.highlightedColor = new Color(Mathf.Clamp01(playerColor.r * 1.2f), Mathf.Clamp01(playerColor.g * 1.2f), Mathf.Clamp01(playerColor.b * 1.2f), 1f); // putin mai deschis
        cb.pressedColor = new Color(playerColor.r * 0.8f, playerColor.g * 0.8f, playerColor.b * 0.8f, 1f); // putin mai inchis
        cb.disabledColor = Color.gray;
        passButtonComponent.colors = cb;
    }
    
    private void DisableButtonTemporarily()
    {
        if (passButtonComponent != null) passButtonComponent.gameObject.SetActive(false);
    }

    private void UpdateButtonState(TurnPhase currentPhase)
    {
        switch (currentPhase)
        {
            case TurnPhase.MainPhase1:
                passButtonComponent.gameObject.SetActive(true);
                passButtonComponent.interactable = true;
                passButtonText.text = "TO ORP";
                break;

            case TurnPhase.OffensiveRollPhase or TurnPhase.DefensiveRollPhase:
                passButtonComponent.gameObject.SetActive(true);
                passButtonComponent.interactable = true; 
                passButtonText.text = "PASS";
                break;

            // case TurnPhase.DefensiveRollPhase:
            //     passButtonComponent.gameObject.SetActive(true);
            //     passButtonComponent.interactable = true;
            //     passButtonText.text = "PASS DEFENSE";
            //     break;

            case TurnPhase.MainPhase2:
                passButtonComponent.gameObject.SetActive(true);
                passButtonComponent.interactable = true;
                passButtonText.text = "END TURN";
                break;

            default:
                passButtonComponent.gameObject.SetActive(false);
                break;
        }
    }

    private void OnPassButtonClicked()
    {
        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.PassPriority(true);
        }
        else
        {
            BattleManager.Instance.AdvancePhase();
        }
        
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
    }
}