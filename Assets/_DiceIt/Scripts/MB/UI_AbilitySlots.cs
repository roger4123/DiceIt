using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_AbilitySlots : MonoBehaviour
{
    [Header("Data")]
    public BaseAbilityData assignedAbility;
    public int slotIndex;

    [Header("UI Components")]
    public TextMeshProUGUI nameText;

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnSlotClicked);
    }

    public void Setup(BaseAbilityData ability)
    {
        assignedAbility = ability;
        if (nameText != null && ability != null)
        {
            nameText.text = ability.abilityName;
        }
    }

    private void OnSlotClicked()
    {
        if (assignedAbility == null) return;

        Debug.Log($"==> Ability pressed: {assignedAbility.abilityName}");
        
        // + modal
    }
}