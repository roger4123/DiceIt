using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UI_TokensPoolSlot : MonoBehaviour
{
    public PlayerController owner;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnSlotClicked);
    }

    private void OnSlotClicked()
    {
        if (owner != null && UI_TokensPoolModal.Instance != null)
        {
            UI_TokensPoolModal.Instance.Show(owner);
        }
    }
}