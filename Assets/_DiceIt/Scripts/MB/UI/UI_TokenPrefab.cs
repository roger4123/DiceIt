using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class UI_TokenPrefab : MonoBehaviour, IPointerClickHandler
{
    public Image iconImage;
    public TextMeshProUGUI stackText;

    private StatusEffectsData data;
    private int currentStacks;

    public void Setup(StatusEffectsData statusData, int stacks)
    {
        data = statusData;
        currentStacks = stacks;

        if (data.icon != null) iconImage.sprite = data.icon;
        stackText.text = $"{stacks}/{data.stackLimit}";

        if (iconImage != null)
        {
            Color iconColor = iconImage.color;
            iconColor.a = (stacks <= 0) ? 0.8f : 1f;
            iconImage.color = iconColor;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // RightClick for Details
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (UI_TokenDetailModal.Instance != null && data != null)
            {
                UI_TokenDetailModal.Instance.Show(data, currentStacks);
            }
        }
        // LeftClick - spending/selection
        else if (eventData.button == PointerEventData.InputButton.Left)
        {
            // selection for removing/transferring
            if (UI_TokensPoolModal.Instance != null && UI_TokensPoolModal.Instance.IsSelectingToken)
            {
                if (currentStacks > 0)
                {
                    UI_TokensPoolModal.Instance.SelectToken(data);
                }
                else Debug.Log($"[TokensPool] Current pool for {data.effectName} is 0!");
                
                return;
            }

            // spending
            if (data != null)
            {
                if (data.isSpendable)
                {
                    if (currentStacks > 0)
                    {
                        PlayerController owner = UI_TokensPoolModal.Instance.CurrentOwner;
                        Debug.Log($"Token {data.effectName} was spent!");
                        // TODO: logica reala de spend (scadem stackul si declansam efectul)
                    }
                    else Debug.Log($"Token {data.effectName} cannot be spent (0 stacks).");
                }
                else
                {
                    Debug.Log($"Token {data.effectName} not spendable.");
                }
            }
        }
    }
}