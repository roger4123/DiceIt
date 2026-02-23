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

    [Header("Abilities")]
    public List<AbilityData> offensiveAbilities;
    public List<AbilityData> defensiveAbilities;
    public AbilityData passiveAbility;

    [Header("Resources")]
    public DiceKeyData diceKey; 
    // public List<StatusEffectData> possibleStatusEffects;
}
