using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

[RequireComponent(typeof(Button))]
public class UI_RollButton : MonoBehaviour
{
    private Button rollButton;
    
    [Header("Ownership")]
    public PlayerController ownerPlayer;
    public TextMeshProUGUI rollButtonText;

    private void Awake()
    {
        rollButton = GetComponent<Button>();
        rollButton.onClick.AddListener(OnRollClicked);
    }

    private void OnRollClicked()
    {
        UnityEngine.EventSystems.EventSystem.current.SetSelectedGameObject(null);
    }

    private void Start()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += UpdateButtonState;
            BattleManager.Instance.OnDefenseSelected += UpdateButtonOnEvent;
            BattleManager.Instance.OnAbilityActivated += UpdateButtonOnEvent;
            UpdateButtonState(BattleManager.Instance.currentPhase);
        }

        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged += UpdateRollText;
            UpdateRollText(DiceManager.Instance.dice, DiceManager.Instance.rollsLeft);
        }
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= UpdateButtonState;
            BattleManager.Instance.OnDefenseSelected -= UpdateButtonOnEvent;
            BattleManager.Instance.OnAbilityActivated -= UpdateButtonOnEvent;
        }

        if (DiceManager.Instance != null)
        {
            DiceManager.Instance.OnDiceStateChanged -= UpdateRollText;
        }
    }

    private void UpdateButtonOnEvent()
    {
        UpdateButtonState(BattleManager.Instance.currentPhase);
    }

    private void UpdateRollText(List<DiceManager.DieState> currentDice, int rollsLeft)
    {
        if (rollButtonText != null)
        {
            rollButtonText.text = $"ROLL\n({rollsLeft} left)";
        }
        
        if (BattleManager.Instance != null) UpdateButtonState(BattleManager.Instance.currentPhase);
    }

    private void UpdateButtonState(TurnPhase currentPhase)
    {
        ColorBlock cb = rollButton.colors;
        cb.disabledColor = Color.gray;
        rollButton.colors = cb;

        if (ownerPlayer == null || BattleManager.Instance == null || BattleManager.Instance.hasActivatedAbilityThisPhase)
        {
            rollButton.interactable = false;
            return;
        }

        bool canRoll = false;

        // only for active player
        if (currentPhase == TurnPhase.OffensiveRollPhase && BattleManager.Instance.activePlayer == ownerPlayer)
        {
            canRoll = true;
        }
        // only for opponent 
        else if (currentPhase == TurnPhase.DefensiveRollPhase && BattleManager.Instance.opponentPlayer == ownerPlayer)
        {
            // prevent rolling before selecting Defensive Ability
            if (!BattleManager.Instance.needsDefenseSelection && BattleManager.Instance.pendingDefenseSelection != null)
            {
                canRoll = true;
            }
        }

        // TODO: verificare daca pe stack exista o carte/status care necesita rolls

        if (DiceManager.Instance != null && DiceManager.Instance.rollsLeft <= 0)
        {
            canRoll = false;
        }

        rollButton.interactable = canRoll;
    }
}