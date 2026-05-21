using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class UI_TokenPrefab : MonoBehaviour, IPointerClickHandler
{
    public Image iconImage;
    public Image backgroundImage;
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
            Color c = data.iconColor;
            c.a = (stacks <= 0) ? 0.8f : 1f;
            iconImage.color = c;
        }
        
        if (backgroundImage != null)
        {
            backgroundImage.color = data.backgroundColor;
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
                    PlayerController owner = UI_TokensPoolModal.Instance.CurrentOwner;

                    // ca
                    if (ActionStackManager.Instance != null && owner != ActionStackManager.Instance.playerWithPriority)
                    {
                        Debug.LogWarning($"[TokensPool] Cant't spend a token right now! Either you don't have priority or the selected token is the oponent's one.");
                        return;
                    }

                    // Regula 2: Verificăm dacă regulile specifice tokenului sunt îndeplinite (ex: Combo / Invisibility)
                    if (!owner.CanSpendStatus(data))
                    {
                        Debug.LogWarning($"[TokensPool] The conditions for spending {data.effectName} are not fulfilled!");
                        return;
                    }

                    if (currentStacks > 0)
                    {
                        owner.SpendStatus(data);
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