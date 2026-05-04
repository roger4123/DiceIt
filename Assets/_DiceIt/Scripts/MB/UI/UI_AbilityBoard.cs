using UnityEngine;
using System.Collections.Generic;

public class UI_AbilityBoard : MonoBehaviour
{
    [Header("Target")]
    public PlayerController targetPlayer;

    [Header("UI Elements")]
    public List<UI_AbilitySlot> abilitySlots = new List<UI_AbilitySlot>();

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization += PopulateBoard;
            targetPlayer.OnAbilitiesChanged += RefreshBoard;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization -= PopulateBoard;
            targetPlayer.OnAbilitiesChanged -= RefreshBoard;
        }
    }

    private void RefreshBoard()
    {
        PopulateBoard(targetPlayer.characterData, targetPlayer);
    }

    private void PopulateBoard(CharacterData characterData, PlayerController owner)
    {
        if (characterData == null || abilitySlots.Count == 0 || owner == null) return;

        bool hasPassive = owner.activePassive != null && !string.IsNullOrEmpty(owner.activePassive.abilityName);

        foreach (var slot in abilitySlots)
        {
            BaseAbilityData dataToAssign = null;
            int idx = slot.slotIndex;

            switch(idx)
            {
                case int i when i >= 0 && i <= 3:
                    if (i < owner.activeOffensiveAbilities.Count)
                    {
                        dataToAssign = owner.activeOffensiveAbilities[i];
                    }
                    break;

                case 4:
                    int offIndexForA6 = hasPassive ? 4 : 5;
                    if (owner.activeOffensiveAbilities.Count > offIndexForA6)
                        dataToAssign = owner.activeOffensiveAbilities[offIndexForA6];
                    break;

                case 10:
                    // Passive Ability has priority
                    if (hasPassive)
                    {
                        dataToAssign = owner.activePassive;
                    }
                    else if (owner.activeOffensiveAbilities.Count > 4)
                    {
                        dataToAssign = owner.activeOffensiveAbilities[4];
                    }
                    break;

                case 20:
                    if (owner.activeDefensiveAbilities.Count > 0)
                    {
                        dataToAssign = owner.activeDefensiveAbilities[0];
                    }
                    break;

                case 21:
                    if (owner.activeDefensiveAbilities.Count > 1)
                    {
                        dataToAssign = owner.activeDefensiveAbilities[1];
                    }
                    else
                    {
                        int offIndexforA7 = hasPassive ? 5 : 6;
                        if (owner.activeOffensiveAbilities.Count > offIndexforA7)
                        {
                            dataToAssign = owner.activeOffensiveAbilities[offIndexforA7];
                        }
                    }
                    break;

                case 50:
                    dataToAssign = owner.activeUltimate;
                    break;
            }

            if (dataToAssign != null)
            {
                slot.gameObject.SetActive(true);
                slot.Setup(dataToAssign, owner);
            }
            else
            {
                slot.gameObject.SetActive(false);
            }            
        }
    }
}