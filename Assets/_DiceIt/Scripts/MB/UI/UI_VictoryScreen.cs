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
        if (victoryPanel != null) 
        {
            victoryPanel.SetActive(true);
            transform.SetAsLastSibling();
        }
        
        if (victoryText != null && winner != null && winner.characterData != null) 
        {
            victoryText.text = $"VICTORY!\n{winner.characterData.heroName} won the game!";
            victoryText.color = winner.characterData.diceKey.dieColor;
        }
        
        Time.timeScale = 0f;
    }
}