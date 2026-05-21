using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_VictoryScreen : MonoBehaviour
{
    [Header("UI References")]
    public GameObject victoryPanel;
    public TextMeshProUGUI victoryText;

    private void Start()
    {
        if (victoryPanel != null)
        {
            Canvas canvas = victoryPanel.GetComponent<Canvas>();
            if (canvas == null)
            {
                canvas = victoryPanel.AddComponent<Canvas>();
                victoryPanel.AddComponent<GraphicRaycaster>();
            }
            canvas.overrideSorting = true;
            canvas.sortingOrder = 30000;
            
            victoryPanel.SetActive(false);
        }
        
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnGameOver += HandleGameOver;
        }
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnGameOver -= HandleGameOver;
        }
    }

    private void HandleGameOver(PlayerController winner)
    {
        if (victoryPanel != null) victoryPanel.SetActive(true);
        
        if (victoryText != null && winner != null && winner.characterData != null) 
        {
            victoryText.text = $"VICTORY!\n{winner.characterData.heroName} WON!";
            victoryText.color = winner.characterData.diceKey.dieColor; // Colorează textul în culoarea eroului!
        }
        
        Time.timeScale = 0f;
    }
}