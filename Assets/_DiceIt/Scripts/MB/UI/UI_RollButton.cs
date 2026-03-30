using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UI_RollButton : MonoBehaviour
{
    private Button rollButton;

    private void Awake()
    {
        rollButton = GetComponent<Button>();
    }

    private void Start()
    {
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
        if (currentPhase == TurnPhase.OffensiveRollPhase || currentPhase == TurnPhase.DefensiveRollPhase)
        {
            rollButton.interactable = true;
        }
        else
        {
            rollButton.interactable = false;
        }
    }
}