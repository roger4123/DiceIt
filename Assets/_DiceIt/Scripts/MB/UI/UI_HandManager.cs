using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class UI_HandManager : MonoBehaviour
{
    [Header("Target Player")]
    public PlayerController targetPlayer;

    [Header("UI References")]
    public GameObject cardPrefab;
    public Transform handContainer;

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnHandChanged += UpdateHandVisuals;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnHandChanged -= UpdateHandVisuals;
        }
    }

    public void UpdateHandVisuals()
    {
        if (handContainer == null || cardPrefab == null || targetPlayer == null) return;

        // cleaning old cards from the UI
        foreach (Transform child in handContainer)
        {
            Destroy(child.gameObject);
        }

        // drawing the new ones
        int sortOrderIndex = 1;
        foreach (CardData card in targetPlayer.hand)
        {
            GameObject cardObj = Instantiate(cardPrefab, handContainer);
            UI_CardController cardController = cardObj.GetComponent<UI_CardController>();
            
            if (cardController != null)
            {
                cardController.Initialize(card, targetPlayer);
                cardController.SetCardOrder(sortOrderIndex);
            }
            sortOrderIndex++;
        }

        // dynamic spacing
        HorizontalLayoutGroup layoutGroup = handContainer.GetComponent<HorizontalLayoutGroup>();
        RectTransform containerRect = handContainer.GetComponent<RectTransform>();
        RectTransform cardRect = cardPrefab.GetComponent<RectTransform>();

        if (layoutGroup != null && containerRect != null && cardRect != null)
        {
            int cardCount = targetPlayer.hand.Count;
            if (cardCount > 1)
            {
                float availableWidth = containerRect.rect.width;
                float cardWidth = cardRect.rect.width;
                
                float dynamicSpacing = ((availableWidth - cardWidth) / (cardCount - 1)) - cardWidth;
                
                layoutGroup.spacing = Mathf.Min(dynamicSpacing, 5f); 
            }
            else
            {
                layoutGroup.spacing = 0f;
            }
        }
    }
}