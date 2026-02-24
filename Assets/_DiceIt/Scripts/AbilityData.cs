using UnityEngine;
using System.Collections.Generic;

// "None" is for abilities that don't deal dmg but are used for resource gathering or healing etc.
public enum AttackType { Normal, Undefendable, Pure, Collateral, Ultimate, None }
public enum RequirementType { SpecificSymbols, SmallStraight, LargeStraight }
public enum ConditionType { Always, SpecificSymbols, SumValue, Parity }
public enum CompareMode { None, LessOrEqual, GreaterOrEqual, Exactly }

[System.Serializable]
public class StatusApplication
{
    public StatusEffectData status;
    public int amount = 1;
}

[System.Serializable]
public class SymbolRequirement
{
    public DiceSymbol symbol;
    public int count;
}

[System.Serializable]
public class AbilityOutcome
{
    public string label; 
    public StatusTarget target; // Self/Opponent
    public OutcomeType type;   // Damage, Healing, AttackModifier, Prevent, etc.
    public float value;
    public List<StatusApplication> statuses;

    [Header("Conditionality")]
    public ConditionType condition = ConditionType.Always;
    public List<SymbolRequirement> symbolRequirements; // for "On Symbol" or "X Symbol"
    public bool isScaling; // TRUE: value * symbolCount. FALSE: fixed value (On Symbol)
    
    [Space]
    public CompareMode compareMode = CompareMode.None; // abilities like Spider-Reflexes
    public int threshold;
}

[System.Serializable]
public class SecondaryRoll
{
    public string label;
    public int diceCount;
    public List<AbilityOutcome> outcomes;
}

[System.Serializable]
public class AbilityActivation
{
    public string label;
    public RequirementType type;
    public List<SymbolRequirement> symbolsNeeded;
    
    [Header("Primary Outcomes (Guaranteed)")]
    public List<AbilityOutcome> primaryOutcomes;

    [Header("Secondary Rolls (Optional)")]
    public List<SecondaryRoll> secondaryRolls;

    [Header("Defense Settings")]
    public int diceToRoll = 5; 
    [Range(0, 1)] public float damageMitigation; // 0.5 or 1 for preventing dmg
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