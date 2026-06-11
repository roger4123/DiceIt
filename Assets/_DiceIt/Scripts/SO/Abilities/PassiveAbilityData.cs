using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PassiveAbility", menuName = "DiceIt/Abilities/PassiveAbility")]
public class PassiveAbilityData : BaseAbilityData
{
    [Header("Logic")]
    public PassiveTrigger trigger;
    public List<AbilityOutcome> primaryPassiveOutcomes;
    public bool ignoreUltimate = true;
}