using UnityEngine;
using System.Collections.Generic;

public class UI_AbilityBoard : MonoBehaviour
{
    [Header("Target")]
    public PlayerController targetPlayer;

    [Header("UI Elements")]
    public List<UI_AbilitySlots> abilitySlots = new List<UI_AbilitySlots>();

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization += PopulateBoard;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization -= PopulateBoard;
        }
    }

    private void PopulateBoard(CharacterData characterData, PlayerController owner)
    {
        if (characterData == null || abilitySlots.Count == 0) return;

        bool hasPassive = characterData.passive != null && !string.IsNullOrEmpty(characterData.passive.abilityName);

        foreach (var slot in abilitySlots)
        {
            BaseAbilityData dataToAssign = null;
            int idx = slot.slotIndex;

            switch(idx)
            {
                case int i when i >= 0 && i <= 3:
                    if (i < characterData.offensiveAbilities.Count)
                    {
                        dataToAssign = characterData.offensiveAbilities[i];
                    }
                    break;

                case 4:
                    int offIndexForA6 = hasPassive ? 4 : 5;
                    if (characterData.offensiveAbilities.Count > offIndexForA6)
                        dataToAssign = characterData.offensiveAbilities[offIndexForA6];
                    break;

                case 10:
                    // Passive Ability has priority
                    if (hasPassive)
                    {
                        dataToAssign = characterData.passive;
                    }
                    else if (characterData.offensiveAbilities.Count > 4)
                    {
                        dataToAssign = characterData.offensiveAbilities[4];
                    }
                    break;

                case 20:
                    if (characterData.defensiveAbilities.Count > 0)
                    {
                        dataToAssign = characterData.defensiveAbilities[0];
                    }
                    break;

                case 21:
                    if (characterData.defensiveAbilities.Count > 1)
                    {
                        dataToAssign = characterData.defensiveAbilities[1];
                    }
                    else
                    {
                        int offIndexforA7 = hasPassive ? 5 : 6;
                        if (characterData.offensiveAbilities.Count > offIndexforA7)
                        {
                            dataToAssign = characterData.offensiveAbilities[offIndexforA7];
                        }
                    }
                    break;

                case 50:
                    dataToAssign = characterData.ultimateAbility;
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