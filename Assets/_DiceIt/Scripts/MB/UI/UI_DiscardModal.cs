using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
using System.Collections;

public class UI_DiscardModal : MonoBehaviour
{
    public static UI_DiscardModal Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    public Transform cardsContainer;
    public GameObject cardPrefab;
    public Button closeButton;
    public TextMeshProUGUI titleText;
    public ScrollRect scrollRect;

    private PlayerController currentTarget;
    private List<GameObject> spawnedCards = new List<GameObject>();

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        if (closeButton != null) closeButton.onClick.AddListener(Hide);
        Hide();
    }

    public void Show(PlayerController player)
    {
        if (player == null) return;
        
        currentTarget = player;
        
        if (titleText != null)
        {
            titleText.text = $"{currentTarget.characterData.heroName}'s Discard Pile";
        }

        RefreshCards();
        
        currentTarget.OnDiscardChanged += RefreshCards;
        
        modalPanel.SetActive(true);
        transform.SetAsLastSibling();
    }

    public void Hide()
    {
        if (currentTarget != null)
        {
            currentTarget.OnDiscardChanged -= RefreshCards;
        }
        currentTarget = null;
        modalPanel.SetActive(false);
    }

    private void RefreshCards()
    {
        if (currentTarget == null) return;

        foreach (var cardObj in spawnedCards) Destroy(cardObj);
        spawnedCards.Clear();

        for (int i = currentTarget.discardPile.Count - 1; i >= 0; i--)
        {
            var cardData = currentTarget.discardPile[i];
            GameObject obj = Instantiate(cardPrefab, cardsContainer);
            
            UI_CardController cardController = obj.GetComponent<UI_CardController>();
            if (cardController != null)
            {
                cardController.Initialize(cardData, currentTarget);
                cardController.SetViewOnly();
            }

            spawnedCards.Add(obj);
        }

        if (gameObject.activeInHierarchy) StartCoroutine(ScrollToTop());
    }

    private IEnumerator ScrollToTop()
    {
        yield return new WaitForEndOfFrame();
        if (scrollRect != null)
            scrollRect.verticalNormalizedPosition = 1f; // 1 = top, 0 = bottom
    }
}
