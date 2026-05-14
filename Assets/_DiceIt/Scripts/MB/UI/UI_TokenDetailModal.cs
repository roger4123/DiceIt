using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_TokenDetailModal : MonoBehaviour
{
    public static UI_TokenDetailModal Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    public Image statusIcon;
    public TextMeshProUGUI statusNameText;
    public TextMeshProUGUI statusTypeText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI limitsText;
    public Button closeButton;

    private void Awake()
    {
        Instance = this;
        if (closeButton != null) closeButton.onClick.AddListener(Hide);
        Hide();
    }

    public void Show(StatusEffectsData data, int currentStacks)
    {
        if (data == null) return;

        if (data.icon != null) statusIcon.sprite = data.icon;
        statusNameText.text = data.effectName;
        
        if (data.isUnique)
        {
            statusTypeText.text = "Unique";
            statusTypeText.color = Color.yellow;
        }
        else
        {
            statusTypeText.text = data.type.ToString();
            statusTypeText.color = data.type == StatusType.Positive ? Color.green : Color.red;
        }

        descriptionText.text = data.description;
        limitsText.text = $"Current Stacks: {currentStacks} / {data.stackLimit}\n" +
                          $"Global Game Limit: {data.maxGlobalTokens}\n" +
                          $"Transferable: {(data.isTransferable ? "Yes" : "No")}";

        modalPanel.SetActive(true);
        transform.SetAsLastSibling(); // Forteaza Detail-ul sa se puna in fata Pool-ului
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}