using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class UI_PhaseTracker : MonoBehaviour
{
    [Header("Phase UI Elements")]
    public List<TextMeshProUGUI> phaseLetters;
    
    public Color normalColor = Color.gray;
    public Color activeColor = Color.green;

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
         if (string.IsNullOrEmpty(message))
        {
            notificationPanel.SetActive(false);
        }
        else
        {
            notificationPanel.SetActive(true);
            notificationText.text = message;
        }
    }
}