using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PlayerDecks : MonoBehaviour
{
    [Header("Target")]
    public PlayerController targetPlayer;

    [Header("UI References")]
    public TextMeshProUGUI drawPileCountText;
    public UI_CardController topCardDisplay; 
    public Button discardPileButton;

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnDeckChanged += UpdateDrawPile;
            targetPlayer.OnDiscardChanged += UpdateDiscardPile;
            targetPlayer.OnCharacterInitialization += HandleInit;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnDeckChanged -= UpdateDrawPile;
            targetPlayer.OnDiscardChanged -= UpdateDiscardPile;
            targetPlayer.OnCharacterInitialization -= HandleInit;
        }
    }

    private void Start()
    {
        if (discardPileButton != null)
        {
            discardPileButton.onClick.AddListener(OnDiscardPileClicked);
        }
    }

    private void HandleInit(CharacterData data, PlayerController player)
    {
        UpdateDrawPile();
        UpdateDiscardPile();
    }

    private void UpdateDrawPile()
    {
        if (drawPileCountText != null && targetPlayer != null)
        {
            drawPileCountText.text = targetPlayer.drawDeck.Count.ToString();
        }
    }

    private void UpdateDiscardPile()
    {
        if (topCardDisplay != null && targetPlayer != null)
        {
            if (targetPlayer.discardPile.Count > 0)
            {
                var topCard = targetPlayer.discardPile[targetPlayer.discardPile.Count - 1];
                topCardDisplay.gameObject.SetActive(true);
                topCardDisplay.Initialize(topCard, targetPlayer);
                topCardDisplay.SetViewOnly();
            }
            else
            {
                topCardDisplay.gameObject.SetActive(false);
            }
        }
    }

    private void OnDiscardPileClicked()
    {
        if (UI_DiscardModal.Instance != null && targetPlayer != null)
        {
            UI_DiscardModal.Instance.Show(targetPlayer);
        }
    }
}
