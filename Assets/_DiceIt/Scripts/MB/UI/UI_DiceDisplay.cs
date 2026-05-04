using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_DiceDisplay : MonoBehaviour
{
    public Image backgroundImage;
    public Image symbolImage;
    public TextMeshProUGUI valueText;
    public GameObject lockDieOverlay;
    
    private int diceIndex;
    private PlayerController owner;

    public void SetIndex(int index)
    {
        diceIndex = index;
    }

    public void SetupOwner(PlayerController player)
    {
        owner = player;
    }

    public void OnDieClick()
    {
        DiceManager.Instance.OnDieClicked(diceIndex, owner);
    }

    public void SetupPlayDie(int value, DiceSymbol data, Color diceColor, Color numberColor)
    {
        if (data == null) return;

        backgroundImage.color = diceColor;
        valueText.gameObject.SetActive(true);
        valueText.text = value.ToString();
        valueText.color = numberColor;
        
        symbolImage.gameObject.SetActive(true);
        symbolImage.sprite = data.symbolIcon;
        symbolImage.color = data.symbolColor;
        
        RectTransform rt = symbolImage.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0);
        rt.anchorMax = new Vector2(1, 0.5f);
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
    }

    public void SetupRequirementDie(DiceSymbol data, Color backgroundColor)
    {
        if (data == null) return;

        backgroundImage.color = backgroundColor;
        valueText.gameObject.SetActive(false); // hide the number
        
        symbolImage.sprite = data.symbolIcon;
        symbolImage.color = data.symbolColor;
        
        RectTransform rt = symbolImage.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.2f, 0.2f);
        rt.anchorMax = new Vector2(0.8f, 0.8f);
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
    }

    public void SetupBlankDie(Color bgColor)
    {
        bgColor.a = 1f;
        backgroundImage.color = bgColor; 
        
        valueText.gameObject.SetActive(false);
        symbolImage.gameObject.SetActive(false);
    }

    public void SetLockVisual(bool isLocked)
    {
        if (lockDieOverlay != null)
        {
            lockDieOverlay.SetActive(isLocked);
        }
    }
}