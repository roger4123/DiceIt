using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_CardModal : MonoBehaviour
{
    public static UI_CardModal Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    
    [Header("Card Display")]
    public UI_CardController displayCard;

    [Header("Buttons")]
    public Button playButton;
    public Button sellButton;
    public Button closeButton;
    public TextMeshProUGUI playButtonText;

    private CardData currentCard;
    private PlayerController currentOwner;

    private void Awake()
    {
        Instance = this;
        
        if (playButton != null) playButton.onClick.AddListener(OnPlayClicked);
        if (sellButton != null) sellButton.onClick.AddListener(OnSellClicked);
        if (closeButton != null) closeButton.onClick.AddListener(Hide);

        Hide();
    }

    public void Show(CardData card, PlayerController owner)
    {
        if (card == null || owner == null) return;

        currentCard = card;
        currentOwner = owner;

        if (displayCard != null)
        {
            displayCard.Initialize(card, owner);
            displayCard.enabled = false;

            Canvas cardCanvas = displayCard.GetComponent<Canvas>();
            if (cardCanvas != null) cardCanvas.sortingOrder = 205;
        }

        ValidateButtons();

        modalPanel.SetActive(true);
    }

    private void ValidateButtons()
    {
        TurnPhase phase = BattleManager.Instance.currentPhase;
        bool isMainPhase = (phase == TurnPhase.MainPhase1 || phase == TurnPhase.MainPhase2);
        bool canSell = isMainPhase && (BattleManager.Instance.activePlayer == currentOwner);
        sellButton.interactable = canSell;

        bool isCorrectPhaseForCard = false;
        switch (currentCard.playPhase)
        {
            case CardPlayPhase.MainPhase:
                isCorrectPhaseForCard = isMainPhase;
                break;
            case CardPlayPhase.RollPhase:
                isCorrectPhaseForCard = (phase == TurnPhase.OffensiveRollPhase || phase == TurnPhase.DefensiveRollPhase);
                break;
            case CardPlayPhase.Instant:
                isCorrectPhaseForCard = true;
                break;
        }

        bool hasEnoughCP = currentOwner.currentCombatPoints >= currentCard.cpCost;
        
        bool hasPriority = ActionStackManager.Instance != null && ActionStackManager.Instance.playerWithPriority == currentOwner;

        if (!hasEnoughCP && playButtonText != null) playButtonText.text = "NO CP!";
        else if (playButtonText != null) playButtonText.text = "PLAY";

        playButton.interactable = isCorrectPhaseForCard && hasEnoughCP && hasPriority;
    }

    private void OnPlayClicked()
    {
        if (CardResolver.Instance != null)
        {
            CardResolver.Instance.PlayCard(currentCard, currentOwner);
        }
        Hide();
    }

    private void OnSellClicked()
    {
        if (CardResolver.Instance != null)
            CardResolver.Instance.SellCard(currentCard, currentOwner);
        Hide();
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}