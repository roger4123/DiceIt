using UnityEngine;
using System.Collections.Generic;

// "None" is for abilities that don't deal dmg but are used for resource gathering or healing etc.
public enum DamageType { Normal, Undefendable, Pure, Ultimate, None }
public enum RequirementType { SpecificSymbols, SmallStraight, LargeStraight }
public enum ConditionType { Always, SpecificSymbols, SumValue, Parity }
public enum CompareMode { None, LessOrEqual, GreaterOrEqual, Exactly }
public enum PassiveTrigger { OnTurnStart, OnTurnEnd, OnDamageTaken, OnAttackDealt }

public enum AbilityOutcomeType
{
    None,
    Damage,
    Healing,
    GainCP,
    DrawCard,
    AttackModifier,
    Prevent,
    ModifyRollAttempts,
    PreventHalfDamage
}

[System.Serializable]
public class StatusApplication
{
    public string label;
    public StatusEffectsData status;
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
    public AbilityOutcomeType type;   // Damage, Healing, AttackModifier, Prevent, etc.
    public float value;
    public List<StatusApplication> statuses;

    [Header("Conditionality for Secondary Rolls")]
    public ConditionType condition = ConditionType.Always;
    public List<SymbolRequirement> symbolRequirements; // for "On Symbol" or "X Symbol"
    public bool isScaling; // TRUE: value * symbolCount. FALSE: fixed value (On Symbol)
    
    [Space]
    public CompareMode compareMode = CompareMode.None; // <=, >=, =
    public int threshold;
}

[System.Serializable]
public class SecondaryRoll
{
    public string label;
    public int diceCount;
    public List<AbilityOutcome> outcomes;
}

public abstract class BaseAbilityData : ScriptableObject
{
    [Header("General Info")]
    public string abilityName;
    [TextArea] public string description;
}