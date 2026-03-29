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

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnSlotClicked);
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

        Debug.Log($"==> Ability pressed: {assignedAbility.abilityName}");
        
        // + modal
        UI_AbilityModal.Instance.Show(assignedAbility, owner);
    }
}