using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class UI_PhaseTracker : MonoBehaviour
{
    [Header("Phase UI Elements")]
    public List<TextMeshProUGUI> phaseLetters;
    
    public Color normalColor = Color.gray;
    public Color activeColor = Color.yellow;

    [Header("Notification Pop-up")]
    public GameObject notificationPanel;
    public TextMeshProUGUI notificationText;

    private void Start()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += UpdatePhaseHighlight;
            BattleManager.Instance.OnPhaseNotification += ShowNotification;
        }
        
        if (notificationPanel != null) notificationPanel.SetActive(false);
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= UpdatePhaseHighlight;
            BattleManager.Instance.OnPhaseNotification -= ShowNotification;
        }
    }

    private void UpdatePhaseHighlight(TurnPhase currentPhase)
    {
        // Ascundem automat panoul de notificare când intrăm într-o fază interactivă (M1, ORP, DRP, M2)
        if (currentPhase == TurnPhase.MainPhase1 || currentPhase == TurnPhase.OffensiveRollPhase || 
            currentPhase == TurnPhase.DefensiveRollPhase || currentPhase == TurnPhase.MainPhase2)
        {
            if (notificationPanel != null) notificationPanel.SetActive(false);
        }

        for (int i = 0; i < phaseLetters.Count; i++)
        {
            if (phaseLetters[i] == null) continue;

            // index of the TurnPhase (enum) element
            bool isCurrentPhase = (i == (int)currentPhase);
            
            phaseLetters[i].color = isCurrentPhase ? activeColor : normalColor;
            phaseLetters[i].fontStyle = isCurrentPhase ? FontStyles.Bold : FontStyles.Normal;
        }
    }

    private void ShowNotification(string message)
    {
        if (notificationPanel != null && notificationText != null)
        {
            notificationPanel.SetActive(true);
            notificationText.text = message;
        }
    }
}