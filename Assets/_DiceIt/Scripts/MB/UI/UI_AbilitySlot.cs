using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_AbilitySlot : MonoBehaviour
{
    [Header("Data")]
    public PlayerController owner;
    public BaseAbilityData assignedAbility;
    public int slotIndex;

    [Header("UI Components")]
    public TextMeshProUGUI nameText;
    private Button button;
    private Image backgroundImage;
    private Color defaultColor = Color.white;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnSlotClicked);
        
        backgroundImage = GetComponent<Image>();
        if (backgroundImage != null) defaultColor = backgroundImage.color;
    }

    public void Setup(BaseAbilityData ability, PlayerController slotOwner)
    {
        assignedAbility = ability;
        owner = slotOwner;
        if (nameText != null && ability != null)
        {
            nameText.text = ability.abilityName;
        }
    }

    private void OnSlotClicked()
    {
        if (assignedAbility == null) return;

        //Debug.Log($"==> Ability pressed: {assignedAbility.abilityName}");
        
        UI_AbilityModal.Instance.Show(assignedAbility, owner);
    }

    public void SetHighlight(Color color)
    {
        if (backgroundImage != null) backgroundImage.color = color;
    }
    
    public void ResetHighlight()
    {
        if (backgroundImage != null) backgroundImage.color = defaultColor;
    }
}