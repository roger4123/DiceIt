using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DefensiveAbility", menuName = "DiceIt/Abilities/DefensiveAbility")]
public class DefensiveAbilityData : BaseAbilityData
{
    [Header("Defense Mechanics")]
    public int diceToRoll = 5;
    public List<AbilityOutcome> defenseOutcomes;
}