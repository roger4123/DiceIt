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
            UpdateButtonState(BattleManager.Instance.currentPhase);
        }
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= UpdateButtonState;
        }
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
        BattleManager.Instance.AdvancePhase();
    }
}