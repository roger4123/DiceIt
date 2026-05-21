using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ActivateAbilityAction : IStackableAction
{
    public PlayerController SourcePlayer { get; }
    public BaseAbilityData ability { get; }
    public int activationIndex { get; }
    public List<int> secondaryRollResults { get; }
    public DamageType runtimeAttackType; // temporary overrwrite (for Webbed)

    public string ActionName => ability != null ? ability.abilityName : "Unknown Ability";

    public ActivateAbilityAction(PlayerController source, BaseAbilityData ability, int activationIndex = -1)
    {
        this.SourcePlayer = source;
        this.ability = ability;
        this.activationIndex = activationIndex;
        this.secondaryRollResults = new List<int>();

        if (ability is OffensiveAbilityData offAb) runtimeAttackType = offAb.attackType;
    }

    public ActivateAbilityAction(PlayerController source, BaseAbilityData ability, int activationIndex, List<int> secondaryRollResults)
    {
        this.SourcePlayer = source;
        this.ability = ability;
        this.activationIndex = activationIndex;
        this.secondaryRollResults = secondaryRollResults ?? new List<int>();

        if (ability is OffensiveAbilityData offAb) runtimeAttackType = offAb.attackType;
    }

    public void Execute()
    {
        Debug.Log($"[Action Stack] Executing {ability.abilityName} by {SourcePlayer.characterData.heroName}");

        var bm = BattleManager.Instance;

        if (ability is DefensiveAbilityData defAbility)
        {
            // DEFENSIVE ABILITIES RESOLUTION
            List<int> defDiceValues = DiceManager.Instance.GetCurrentDiceValues();
            DiceKeyData defDiceKey = SourcePlayer.characterData.diceKey;

            foreach (var outcome in defAbility.defenseOutcomes)
            {
                if (bm.IsConditionMet(outcome, defDiceValues, defDiceKey, out float scalingMult))
                {
                    float finalOutcomeValue = outcome.isScaling ? outcome.value * scalingMult : outcome.value;

                    if (outcome.type == OutcomeType.Prevent)
                    {
                        Debug.Log($"[Resolution - Defense] Condition met for Prevention! Preventing {finalOutcomeValue} DMG.");
                        bm.AddTurnPrevention(finalOutcomeValue);
                    }
                    else if (outcome.type == OutcomeType.Damage && outcome.target == StatusTarget.Opponent)
                    {
                        // counterattack
                        Debug.Log($"[Resolution] Counter-Attack! {defAbility.abilityName} deals {finalOutcomeValue} damage back to attacker.");
                        UI_CombatLog.Instance?.LogMessage($"{defAbility.abilityName} counter-attacks for {finalOutcomeValue} DMG!", new Color(1f, 0.6f, 0f));
                        bm.activePlayer.ChangeHealth(-(int)finalOutcomeValue, DamageType.Pure);
                    }
                }
            }
        }
        else if (ability is OffensiveAbilityData offAbility)
        {
            // OFENSIVE ABILITY RESOLUTION
            float incomingDamage = 0;
            var activation = offAbility.activations[activationIndex];

            // resolve damage from primary outcomes
            foreach (var outcome in activation.primaryOutcomes)
            {
                if (outcome.type == OutcomeType.Damage || outcome.type == OutcomeType.AttackModifier) 
                {
                    incomingDamage += outcome.value;
                }
            }

            // resolve damage from secondary roll outcomes
            if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
            {
                var secRoll = activation.secondaryRolls[0];
                foreach (var outcome in secRoll.outcomes)
                {
                    if (bm.IsConditionMet(outcome, secondaryRollResults, SourcePlayer.characterData.diceKey, out float scalingMult))
                    {
                        float finalVal = outcome.isScaling ? outcome.value * scalingMult : outcome.value;
                        Debug.Log($"[Resolution - Offense] Secondary Roll condition met! Value: {finalVal}");
                        if (outcome.type == OutcomeType.Damage || outcome.type == OutcomeType.AttackModifier) incomingDamage += finalVal;
                    }
                }
            }
            
            // passive attack modifier (for Kinetic Energy)
            if (runtimeAttackType != DamageType.None)
            {
                var kinetic = SourcePlayer.activeStatuses.FirstOrDefault(s => s.data.effectName == "Kinetic Energy");
                if (kinetic != null && kinetic.currentStacks >= 2)
                {
                    int bonusDamage = kinetic.currentStacks / 2;
                    incomingDamage += bonusDamage;
                    Debug.Log($"[Resolution - Offense] Kinetic Energy adds {bonusDamage} bonus DMG! (Total stacks: {kinetic.currentStacks})");
                }
            }

            Debug.Log($"[Resolution] Base Incoming Damage: {incomingDamage}");

            float damagePrevention = bm.GetAndClearTurnPrevention();
            Debug.Log($"[Resolution] Damage Prevention from abilities: {damagePrevention}");

            float finalDamage = Mathf.Max(0, incomingDamage - damagePrevention);
            Debug.Log($"[Resolution] Final Damage Total: {finalDamage}");

            if (finalDamage > 0 && bm.opponentPlayer != null)
            {
                UI_CombatLog.Instance?.LogMessage($"{ability.abilityName} deals {finalDamage} DMG to {bm.opponentPlayer.characterData.heroName}.", new Color(1f, 0.4f, 0.4f));
                bm.opponentPlayer.ChangeHealth(-(int)finalDamage, runtimeAttackType);
            }
            else if (incomingDamage > 0)
            {
                UI_CombatLog.Instance?.LogMessage($"{ability.abilityName} was fully blocked!", Color.gray);
            }
        }
    }
}