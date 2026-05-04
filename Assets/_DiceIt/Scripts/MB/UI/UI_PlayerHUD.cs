using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PlayerHUD : MonoBehaviour
{
    [Header("Target")]
    public PlayerController targetPlayer;

    [Header("UI Elements")]
    public TextMeshProUGUI healthBarandCPText;
    public Image backgroundImage;

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnStatsChanged += UpdateHUDText;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnStatsChanged -= UpdateHUDText;
        }
    }

    private void UpdateHUDText(int curHP, int maxHP, int curCP, int maxCP)
    {
        if (healthBarandCPText != null && targetPlayer.characterData != null)
        {
            Color playerColor = targetPlayer.characterData.diceKey.dieColor;
            
            healthBarandCPText.text = $"{targetPlayer.characterData.heroName}: {curHP}/{maxHP} HP | {curCP}/{maxCP} CP";
            healthBarandCPText.color = playerColor;

            if (backgroundImage != null)
            {
                backgroundImage.color = targetPlayer.characterData.hudBackgroundColor;
            }
        }
    }
}