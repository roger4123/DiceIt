using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class UI_CardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [Header("Data")]
    public CardData cardData;

    [Header("UI References")]
    public Image cardBackground;
     public Image cardBorder;
    public Image cardImage; // The main custom artwork
    public Image iconBackground; 
    public Image cardIcon; // The mini type icon (Main, Roll, Instant)
    public Image costBackground;
     public TextMeshProUGUI costText;
    public TextMeshProUGUI cardNameText;
    public TextMeshProUGUI descriptionText;
   
    [Header("Type Icons Settings")]
    public Sprite mainPhaseSprite;
    public Sprite rollPhaseSprite;
    public Sprite instantSprite;

    [Header("Type Icons Colors")]
    public Color mainPhaseColor = Color.blue;
    public Color rollPhaseColor = Color.orange;
    public Color instantColor = Color.red;

    [Header("Interaction FX")]
    public float zoomScale = 1.1f;
    private Vector3 initialScale;
    private Canvas cardCanvas;
    private PlayerController owner;
    private int baseSortingOrder = 1;

    private void Awake()
    {
        initialScale = transform.localScale;
    }

    public void Initialize(CardData data, PlayerController ownerPlayer = null)
    {
        this.cardData = data;
        this.owner = ownerPlayer;

        if (cardData == null)
        {
            Debug.LogError("CardData is null on Initialize!");
            gameObject.SetActive(false);
            return;
        }

        cardNameText.text = cardData.cardName;
        descriptionText.text = cardData.description;
        costText.text = cardData.cpCost.ToString();

        // setting the main artwork
        if (cardImage != null)
        {
            if (cardData.cardArtwork != null)
            {
                cardImage.sprite = cardData.cardArtwork;
                cardImage.color = Color.white;
            }
            else
            {
                cardImage.sprite = null;
            }
        }

        // setting the Type Icon
        if (cardIcon != null)
        {
            switch (cardData.playPhase)
            {
                case CardPlayPhase.MainPhase: 
                    cardIcon.sprite = mainPhaseSprite; 
                    cardIcon.color = mainPhaseColor;
                    break;
                case CardPlayPhase.RollPhase: 
                    cardIcon.sprite = rollPhaseSprite; 
                    cardIcon.color = rollPhaseColor;
                    break;
                case CardPlayPhase.Instant: 
                    cardIcon.sprite = instantSprite; 
                    cardIcon.color = instantColor;
                    break;
            }
            cardIcon.enabled = cardIcon.sprite != null;
            if (iconBackground != null) iconBackground.enabled = cardIcon.enabled;
        }

        UpdateBorderColor();
    }

    public void SetAsHandCard(int order)
    {
        baseSortingOrder = order;
        cardCanvas = GetComponent<Canvas>();
        if (cardCanvas == null)
        {
            cardCanvas = gameObject.AddComponent<Canvas>();
            gameObject.AddComponent<GraphicRaycaster>();
        }
        cardCanvas.overrideSorting = true;
        cardCanvas.sortingOrder = baseSortingOrder; 
    }
    
    private void UpdateBorderColor()
    {
        if (cardBorder != null)
        {
            switch (cardData.playPhase)
            {
                case CardPlayPhase.MainPhase: cardBorder.color = mainPhaseColor; break;
                case CardPlayPhase.RollPhase: cardBorder.color = rollPhaseColor; break;
                case CardPlayPhase.Instant: cardBorder.color = instantColor; break;
            }
        }
    }

    public void SetViewOnly()
    {
        Canvas canvas = GetComponent<Canvas>();
        if (canvas != null) Destroy(canvas);
        
        GraphicRaycaster raycaster = GetComponent<GraphicRaycaster>();
        if (raycaster != null) Destroy(raycaster);
        
        this.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // bring to front and scale up
        if (cardCanvas != null) cardCanvas.sortingOrder = baseSortingOrder + 100;
        transform.localScale = initialScale * zoomScale;

        // highlight white for discard if in cleanup phase
        if (BattleManager.Instance != null && BattleManager.Instance.currentPhase == TurnPhase.Cleanup && 
            owner == BattleManager.Instance.activePlayer && owner.hand.Count > 6)
        {
            if (cardBorder != null) cardBorder.color = Color.white;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // return to original state
        transform.localScale = initialScale;
        if (cardCanvas != null) cardCanvas.sortingOrder = baseSortingOrder; 
        
        UpdateBorderColor();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (BattleManager.Instance != null && 
            BattleManager.Instance.currentPhase == TurnPhase.Cleanup && 
            owner == BattleManager.Instance.activePlayer && 
            owner.hand.Count > 6)
        {
            owner.DiscardCard(cardData);
        }
        else if (owner != null && UI_CardModal.Instance != null)
        {
            UI_CardModal.Instance.Show(cardData, owner);
            OnPointerExit(eventData);
        }
    }
}
