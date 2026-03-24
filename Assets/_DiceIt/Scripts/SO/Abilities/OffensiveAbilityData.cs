using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "AttackAbility", menuName = "DiceIt/Abilities/AttackAbility")]
public class OffensiveAbilityData : BaseAbilityData
{
    public AttackType attackType;

    [System.Serializable]
    public class AttackActivation
    {
        public string label;
        public RequirementType type;
        public List<SymbolRequirement> symbolsNeeded;

        [Header("Primary Outcomes (Guaranteed)")]
        public List<AbilityOutcome> primaryOutcomes;

        [Header("Secondary Rolls (Optional)")]
        public List<SecondaryRoll> secondaryRolls;
    }

    public List<AttackActivation> activations;

    public override List<SymbolRequirement> GetActivationSymbols()
    {
        if (activations != null && activations.Count > 0)
        {
            return activations[0].symbolsNeeded;
        }
        return null;
    }

    public override RequirementType GetRequirementType()
    {
        if (activations != null && activations.Count > 0)
            return activations[0].type;
        return RequirementType.SpecificSymbols;
    }
}
