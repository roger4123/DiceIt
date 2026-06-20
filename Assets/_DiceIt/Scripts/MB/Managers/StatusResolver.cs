using UnityEngine;
using System.Linq;

public class StatusResolver : MonoBehaviour
{
    public static StatusResolver Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ResolveTrigger(StatusTrigger trigger, PlayerController source, StatusEffectsData tokenData)
    {
        if (tokenData.primaryStatusEffectOutcomes == null) return;
        foreach (var outcome in tokenData.primaryStatusEffectOutcomes)
        {
            if (outcome.activationTrigger == trigger)
            {
                ApplyOutcome(outcome, source, tokenData);
            }
        }
    }

    public void ResolveSpend(SpendTokenAction action)
    {
        Debug.Log($"[StatusResolver] Resolving spent token: {action.tokenData.effectName} by {action.SourcePlayer.characterData.heroName}");
        UI_CombatLog.Instance?.LogMessage($"Resolving spent token: {action.tokenData.effectName}", Color.black);

        var bm = BattleManager.Instance;
        bool usedForRolls = false;

        // additionall roll in defense
        if (action.tokenData.effectName == "Invisibility" && bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.pendingDefenseSelection != null)
        {
            foreach (var outcome in bm.pendingDefenseSelection.primaryDefensiveOutcomes)
            {
                if (outcome.type == AbilityOutcomeType.ModifyRollAttempts && outcome.statuses != null)
                {
                    if (outcome.statuses.Any(s => s.status.effectName == "Invisibility" && s.amount < 0))
                    {
                        if (DiceManager.Instance != null)
                        {
                            int currentRolls = DiceManager.Instance.rollsLeft;
                            DiceManager.Instance.ResetDice(currentRolls + (int)outcome.value, bm.pendingDefenseSelection.diceToRoll);

                            UI_CombatLog.Instance?.LogMessage($"Spent Invisibility for {outcome.value} extra roll(s)!", Color.black);
                            bm?.ShowNotification($"Spent Invisibility for {outcome.value} extra roll(s)!", 2.5f);
                            usedForRolls = true;
                        }
                        break;
                    }
                }
            }
        }

        if (action.tokenData.primaryStatusEffectOutcomes == null) return;

        foreach (var outcome in action.tokenData.primaryStatusEffectOutcomes)
        {
            if (outcome.activationTrigger == StatusTrigger.OnManualSpend)
            {
                // skip the base effect (ChangeAttackType)
                if (usedForRolls && outcome.type == StatusOutcomeType.ChangeAttackType) continue;

                ApplyOutcome(outcome, action.SourcePlayer, action.tokenData);
            }
        }
    }

    private void ApplyOutcome(StatusOutcome outcome, PlayerController source, StatusEffectsData tokenData)
    {
        var bm = BattleManager.Instance;
        PlayerController actualOpponent = (source == bm.player1) ? bm.player2 : bm.player1;
        PlayerController target = (outcome.target == StatusTarget.Opponent) ? actualOpponent : source;

        switch (outcome.type)
        {
            case StatusOutcomeType.TakeBonusORP:
                Debug.Log($"[StatusResolver] {tokenData.effectName} grants a Bonus Offensive Roll Phase to {target.characterData.heroName}.");
                UI_CombatLog.Instance?.LogMessage($"{target.characterData.heroName} gains a Bonus Offensive Roll Phase from {tokenData.effectName}!", Color.black);
                bm.hasBonusOffensivePhase = true;
                bm.hasUsedComboThisTurn = true;
                break;

            case StatusOutcomeType.ChangeAttackType:
                // base logic for Invisibility
                if (tokenData.effectName == "Invisibility" && bm.currentPhase == TurnPhase.DefensiveRollPhase)
                {
                    UI_CombatLog.Instance?.LogMessage("INVISIBILITY used! Defensive Abilities are now allowed.", Color.black);
                    bm?.ShowNotification("Invisibility active! Defensive Abilities are now allowed.", 2.5f);
                    bm.canActivateDefensiveAbility = true;
                    
                    if (target.activeDefensiveAbilities.Count > 0)
                    {
                        if (target.activeDefensiveAbilities.Count == 1)
                        {
                            bm.SelectDefense(target.activeDefensiveAbilities[0]);
                        }
                        else
                        {
                            bm.needsDefenseSelection = true;
                            if (DiceManager.Instance != null)
                            {
                                DiceManager.Instance.ResetDice(1, 0); 
                                DiceManager.Instance.SetInteractionState(DiceInteractionState.Disabled);
                            }
                        }
                    }
                }
                break;
            
            case StatusOutcomeType.Damage:
                UI_CombatLog.Instance?.LogMessage($"{tokenData.effectName} deals {outcome.value} damage to {target.characterData.heroName}.", Color.black);
                target.ChangeHealth(-(int)outcome.value);
                break;
                
            case StatusOutcomeType.Healing:
                UI_CombatLog.Instance?.LogMessage($"{tokenData.effectName} heals {target.characterData.heroName} for {outcome.value} HP.", Color.black);
                target.ChangeHealth((int)outcome.value);
                break;
                
            case StatusOutcomeType.GainCP:
                UI_CombatLog.Instance?.LogMessage($"{target.characterData.heroName} gains {outcome.value} CP from {tokenData.effectName}.", Color.black);
                target.ChangeCP((int)outcome.value);
                break;
                
            case StatusOutcomeType.DrawCard:
                UI_CombatLog.Instance?.LogMessage($"{target.characterData.heroName} draws {outcome.value} card(s) from {tokenData.effectName}.", Color.black);
                target.DrawCards(Mathf.CeilToInt(outcome.value));
                break;
                
            case StatusOutcomeType.Prevent:
                bm.AddTurnPrevention(target, outcome.value);
                UI_CombatLog.Instance?.LogMessage($"{tokenData.effectName} adds {outcome.value} damage prevention.", Color.black);
                bm?.ShowNotification($"{tokenData.effectName} active! Prevents {outcome.value} damage.", 2.5f);
                break;
        }
    }
}