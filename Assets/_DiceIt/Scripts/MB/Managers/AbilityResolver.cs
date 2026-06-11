using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AbilityResolver : MonoBehaviour
{
    public static AbilityResolver Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ResolveAbility(ActivateAbilityAction action)
    {
        var bm = BattleManager.Instance;
        var ability = action.ability;
        var SourcePlayer = action.SourcePlayer;

            
        #region Defensive Abilities Resolution

        if (ability is DefensiveAbilityData defAbility)
        {
            List<int> defDiceValues = DiceManager.Instance.GetCurrentDiceValues();
            DiceKeyData defDiceKey = SourcePlayer.characterData.diceKey;
            bool defenseSuccessful = false;

            foreach (var outcome in defAbility.primaryDefensiveOutcomes)
            {
                if (IsConditionMet(outcome, defDiceValues, defDiceKey, out float scalingMult))
                {
                    defenseSuccessful = true;
                    float finalOutcomeValue = outcome.isScaling ? outcome.value * scalingMult : outcome.value;

                    if (outcome.type == AbilityOutcomeType.Prevent)
                    {
                        Debug.Log($"[Resolution - Defense] Preventing {finalOutcomeValue} DMG!");
                        UI_CombatLog.Instance?.LogMessage($"{defAbility.abilityName} prevents {finalOutcomeValue} damage!", Color.black);
                        bm.ShowNotification($"Preventing {finalOutcomeValue} DMG!", 2.0f);
                        bm.AddTurnPrevention(SourcePlayer, finalOutcomeValue);
                    }
                    else if (outcome.type == AbilityOutcomeType.PreventHalfDamage)
                    {
                        Debug.Log($"[Resolution - Defense] Incoming damage will be halved!");
                        UI_CombatLog.Instance?.LogMessage($"{SourcePlayer.characterData.heroName}'s incoming damage will be halved!", Color.black);
                        bm.ShowNotification($"Incoming damage will be halved!", 2.0f);
                        bm.HalveTurnDamage();
                    }
                    else if (outcome.type == AbilityOutcomeType.Damage && outcome.target == StatusTarget.Opponent)
                    {
                        // counterattack
                        float preventionUsed = bm.ConsumePrevention(bm.activePlayer, finalOutcomeValue);
                        float finalOutcomeValueAfterPrev = finalOutcomeValue - preventionUsed;

                        Debug.Log($"[Resolution] Counter-Attack! {defAbility.abilityName} deals {finalOutcomeValueAfterPrev} damage back to attacker (Prevented {preventionUsed}).");
                        
                        if (finalOutcomeValueAfterPrev > 0)
                        {
                            UI_CombatLog.Instance?.LogMessage($"{defAbility.abilityName} counter-attacks for {finalOutcomeValueAfterPrev} damage.", Color.black);
                            bm.ShowNotification($"{defAbility.abilityName} counter-attacks for {finalOutcomeValueAfterPrev} damage!", 2.0f);
                            bm.activePlayer.ChangeHealth(-(int)finalOutcomeValueAfterPrev, DamageType.Pure);
                        }
                        else
                        {
                            UI_CombatLog.Instance?.LogMessage($"{defAbility.abilityName}'s counter-attack was blocked!", Color.black);
                        }
                    }
                }
            }
            
            if (defenseSuccessful)
            {
                float counterDmg = bm.GetAndClearTurnCounterDamage();
                if (counterDmg > 0)
                {
                    float preventionUsed = bm.ConsumePrevention(bm.activePlayer, counterDmg);
                    float finalCounterDmg = counterDmg - preventionUsed;

                    Debug.Log($"[Resolution - Defense] Counter Damage from Cards triggers! Dealing {finalCounterDmg} DMG (Prevented {preventionUsed}).");
                    if (finalCounterDmg > 0)
                    {
                        UI_CombatLog.Instance?.LogMessage($"{SourcePlayer.characterData.heroName} strikes back for {finalCounterDmg} DMG!", Color.black);
                        bm.activePlayer.ChangeHealth(-(int)finalCounterDmg, DamageType.Pure);
                    }
                    else
                    {
                        UI_CombatLog.Instance?.LogMessage($"{SourcePlayer.characterData.heroName}'s card counter-attack was blocked!", Color.black);
                    }
                }
            }
            else
            {
                bm.GetAndClearTurnCounterDamage();
            }
        }   
        #endregion

        #region Offensive Abilities Resolution

        else if (ability is OffensiveAbilityData offAbility)
        {
            float baseDamage = 0;
            float modifierDamage = 0;
            var activation = offAbility.activations[action.activationIndex];

            // resolve damage from primary outcomes
            foreach (var outcome in activation.primaryOffensiveOutcomes)
            {
                if (outcome.type == AbilityOutcomeType.Damage || outcome.type == AbilityOutcomeType.AttackModifier) 
                {
                    baseDamage += outcome.value;
                }
            }
            
            if (baseDamage > 0)
            {
                Debug.Log($"[Resolution - Offense] Base Damage from primary outcomes: {baseDamage}");
                UI_CombatLog.Instance?.LogMessage($"Base Damage: {baseDamage}", Color.black);
            }

            // resolve damage from secondary roll outcomes
            if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
            {
                var secRoll = activation.secondaryRolls[0];
                foreach (var outcome in secRoll.outcomes)
                {
                    if (IsConditionMet(outcome, action.secondaryRollResults, SourcePlayer.characterData.diceKey, out float scalingMult))
                    {
                        float finalVal = outcome.isScaling ? outcome.value * scalingMult : outcome.value;
                        Debug.Log($"[Resolution - Offense] Secondary Roll condition met! Adds Modifier DMG: {finalVal}");
                        UI_CombatLog.Instance?.LogMessage($"Secondary Roll adds {finalVal} damage.", Color.black);
                        if (outcome.type == AbilityOutcomeType.Damage || outcome.type == AbilityOutcomeType.AttackModifier) modifierDamage += finalVal;
                    }
                }
            }
            
            // passive attack modifier (for Kinetic Energy)
            if (action.runtimeAttackType != DamageType.None)
            {
                var kinetic = SourcePlayer.activeStatuses.FirstOrDefault(s => s.data.effectName == "Kinetic Energy");
                if (kinetic != null && kinetic.currentStacks >= 2)
                {
                    int bonusDamage = kinetic.currentStacks / 2;
                    modifierDamage += bonusDamage;
                    Debug.Log($"[Resolution - Offense] Kinetic Energy adds {bonusDamage} bonus DMG! (Total stacks: {kinetic.currentStacks})");
                    UI_CombatLog.Instance?.LogMessage($"Kinetic Energy adds {bonusDamage} bonus damage.", Color.black);
                }
            }

            float cardModifier = bm.GetAndClearTurnAttackModifier();
            if (cardModifier > 0)
            {
                modifierDamage += cardModifier;
                Debug.Log($"[Resolution - Offense] Card Modifier adds {cardModifier} DMG!");
                UI_CombatLog.Instance?.LogMessage($"Attack Modifier from cards adds {cardModifier} bonus damage.", Color.black);
            }

            float incomingDamage = baseDamage + modifierDamage;
            Debug.Log($"[Resolution] Total Incoming Attack -> Base: {baseDamage} + Modifiers: {modifierDamage} = {incomingDamage} DMG");
            UI_CombatLog.Instance?.LogMessage($"Total Incoming Attack: {incomingDamage} damage.", Color.black);
            bm.ShowNotification($"Total Incoming Attack: {incomingDamage} damage.", 2.0f);

            bool isDamageHalved = bm.GetAndClearTurnDamageHalved();
            if (isDamageHalved)
            {
                incomingDamage = Mathf.Floor(incomingDamage / 2f);
                Debug.Log($"[Resolution] Damage halved! Incoming Attack reduced to: {incomingDamage}");
                UI_CombatLog.Instance?.LogMessage($"Damage halved! Reduced to {incomingDamage}.", Color.black);
                bm.ShowNotification($"Damage halved! Reduced to {incomingDamage}.", 2.0f);
            }

            float preventionUsed = bm.ConsumePrevention(bm.opponentPlayer, incomingDamage);
            Debug.Log($"[Resolution] Damage Prevention from abilities: {preventionUsed}");
            UI_CombatLog.Instance?.LogMessage($"Blocked {preventionUsed} damage via preventions.", Color.black);

            float finalDamage = Mathf.Max(0, incomingDamage - preventionUsed);
            Debug.Log($"[Resolution] Final Damage Total: {finalDamage}");
            UI_CombatLog.Instance?.LogMessage($"Final Damage Total: {finalDamage}", Color.black);

            if (finalDamage > 0 && bm.opponentPlayer != null)
            {
                UI_CombatLog.Instance?.LogMessage($"{ability.abilityName} deals {finalDamage} DMG to {bm.opponentPlayer.characterData.heroName}.", Color.black);
                bm.ShowNotification($"{ability.abilityName} deals {finalDamage} final damage!", 2.5f);
                bm.opponentPlayer.ChangeHealth(-(int)finalDamage, action.runtimeAttackType);
            }
            else if (incomingDamage > 0)
            {
                UI_CombatLog.Instance?.LogMessage($"{ability.abilityName} was fully blocked!", Color.black);
                bm.ShowNotification($"{ability.abilityName} was fully blocked!", 2.5f);
            }
        }

        #endregion
    }

    public void ProcessInstantEffects(ActivateAbilityAction abilityAction)
    {
        if (abilityAction.ability is OffensiveAbilityData offAb && abilityAction.activationIndex != -1)
        {
            var activation = offAb.activations[abilityAction.activationIndex];
            var primaryDice = DiceManager.Instance != null ? DiceManager.Instance.GetCurrentDiceValues() : new List<int>();
            
            foreach (var outcome in activation.primaryOffensiveOutcomes)
            {
                if (IsConditionMet(outcome, primaryDice, abilityAction.SourcePlayer.characterData.diceKey, out float primaryScalingMult))
                {
                    ApplyInstantEffects(outcome, abilityAction.SourcePlayer, BattleManager.Instance.opponentPlayer, primaryScalingMult);
                }
            }
            
            if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
            {
                var secRoll = activation.secondaryRolls[0];
                foreach (var outcome in secRoll.outcomes)
                {
                    if (IsConditionMet(outcome, abilityAction.secondaryRollResults, abilityAction.SourcePlayer.characterData.diceKey, out float scalingMult))
                    {
                        ApplyInstantEffects(outcome, abilityAction.SourcePlayer, BattleManager.Instance.opponentPlayer, scalingMult);
                    }
                }
            }
        }
    }

    public void ApplyInstantEffects(AbilityOutcome outcome, PlayerController source, PlayerController opponent, float scalingMultiplier = 1f)
    {
        PlayerController target = (outcome.target == StatusTarget.Opponent) ? opponent : source;

        float finalValue = outcome.isScaling ? outcome.value * scalingMultiplier : outcome.value;

        switch (outcome.type)
        {
            case AbilityOutcomeType.GainCP: 
                target.ChangeCP(Mathf.CeilToInt(finalValue)); 
                break;
            case AbilityOutcomeType.DrawCard: 
                target.DrawCards(Mathf.CeilToInt(finalValue)); 
                break;
        }

        if (outcome.statuses != null)
        {
            foreach (var statusApp in outcome.statuses)
            {
                int amountToAdd = outcome.isScaling ? Mathf.CeilToInt(finalValue) : statusApp.amount;
                target.AddStatus(statusApp.status, amountToAdd);
            }
        }
    }

    public bool IsConditionMet(AbilityOutcome outcome, List<int> rolledValues, DiceKeyData diceKey, out float scalingMultiplier)
    {
        scalingMultiplier = 1f;

        if (outcome.condition == ConditionType.Always) return true;

        if (outcome.condition == ConditionType.SpecificSymbols)
        {
            if (outcome.symbolRequirements == null || outcome.symbolRequirements.Count == 0) return false;

            int minSets = int.MaxValue;
            foreach (var req in outcome.symbolRequirements)
            {
                int countInRoll = 0;
                foreach (int val in rolledValues)
                {
                    if (val == 0) continue;
                    var symbolData = diceKey.GetSymbolForValue(val);
                    if (symbolData != null)
                    {
                        if (symbolData == req.symbol) countInRoll++;
                        else if (BattleManager.Instance != null && BattleManager.Instance.isSpiderSenseSwapped && req.symbol.name.Contains("Spider") && symbolData.name.Contains("Web")) countInRoll++;
                    }
                }
                if (countInRoll < req.count) return false;
                minSets = Mathf.Min(minSets, countInRoll / Mathf.Max(1, req.count));
            }
            
            if (outcome.isScaling) scalingMultiplier = minSets;
            return true;
        }

        if (outcome.condition == ConditionType.SumValue)
        {
            int sum = 0;
            foreach (int v in rolledValues) sum += v;
            
            if (outcome.isScaling) scalingMultiplier = sum;

            switch (outcome.compareMode)
            {
                case CompareMode.LessOrEqual: return sum <= outcome.threshold;
                case CompareMode.GreaterOrEqual: return sum >= outcome.threshold;
                case CompareMode.Exactly: return sum == outcome.threshold;
                case CompareMode.None: return true;
            }
        }

        return false;
    }
}