using UnityEngine;
using System.Collections.Generic;

// "None" is for abilities that don't deal dmg but are used for resource gathering or healing etc.
public enum AttackType { Normal, Undefendable, Pure, Collateral, Ultimate, None }
public enum RequirementType { SpecificSymbols, SmallStraight, LargeStraight }

[System.Serializable]
public class AbilityActivation
{
    public string label;
    public RequirementType type;
    public List<SymbolRequirement> symbolsNeeded;
    
    [Header("Standard Combat")]
    public int damage;
    public int healing;
    public List<StatusEffectData> statusToApply;

    [Header("Defense & Scaling")]
    public int diceToRoll = 5; 
    public bool isScaling; // if TRUE, multiply dmg with count
    [Range(0, 1)] public float damageMitigation; // 0.5 or 1 for preventing dmg

    [Header("Variable/Random Effects")]
    public int extraDiceToRoll; 
    public bool useSumAsDamage;
    
    [Space]
    public int thresholdValue;
    public List<StatusEffectData> statusIfUnderThreshold;
}

[System.Serializable]
public class SymbolRequirement
{
    public DiceSymbol symbol;
    public int count;
}

[CreateAssetMenu(fileName = "NewAbility", menuName = "DiceIt/Ability")]
public class AbilityData : ScriptableObject
{
    [Header("General Info")]
    public string abilityName;
    [TextArea] public string description;
    public AttackType attackType;

    [Header("Activations (Options)")]
    public List<AbilityActivation> activations;
}