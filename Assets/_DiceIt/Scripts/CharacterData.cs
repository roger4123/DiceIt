using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "DiceIt/Character")]
public class CharacterData : ScriptableObject
{
    [Header("Identity")]
    public string heroName;
    public Sprite avatar;
    [Range(1, 6)] public int complexityRating = 1;

    [Header("Stats")]
    public int maxHealth = 50;
    public int maxCombatPoints = 15;
    public int startingCombatPoints = 2;
    public int startingCards = 4;

    [Header("Abilities")]
    public List<OffensiveAbilityData> offensiveAbilities;
    public List<DefensiveAbilityData> defensiveAbilities;
    public BaseAbilityData ultimateAbility;
    public PassiveAbilityData passive;

    [Header("Resources")]
    public DiceKeyData diceKey; 
    public List<StatusEffectsData> characterSpecificStatuses;
}