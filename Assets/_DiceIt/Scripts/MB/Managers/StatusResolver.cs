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
        if (tokenData.outcomes == null) return;
        foreach (var outcome in tokenData.outcomes)
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

        var bm = BattleManager.Instance;
        bool usedForRolls = false;

        // additionall roll in defense
        if (action.tokenData.effectName == "Invisibility" && bm.currentPhase == TurnPhase.DefensiveRollPhase && bm.pendingDefenseSelection != null)
        {
            foreach (var outcome in bm.pendingDefenseSelection.defenseOutcomes)
            {
                if (outcome.type == OutcomeType.ModifyRollAttempts && outcome.statuses != null)
                {
                    if (outcome.statuses.Any(s => s.status.effectName == "Invisibility" && s.amount < 0))
                    {
                        if (DiceManager.Instance != null)
                        {
                            int currentRolls = DiceManager.Instance.rollsLeft;
                            DiceManager.Instance.ResetDice(currentRolls + (int)outcome.value, bm.pendingDefenseSelection.diceToRoll);
                            bm.NotifyPhase($"Spent Invisibility for {outcome.value} extra roll(s)!");
                            usedForRolls = true;
                        }
                        break;
                    }
                }
            }
        }

        if (action.tokenData.outcomes == null) return;

        foreach (var outcome in action.tokenData.outcomes)
        {
            if (outcome.activationTrigger == StatusTrigger.OnManualSpend)
            {
                // skip the base effect (ChangeAttackType)
                if (usedForRolls && outcome.type == OutcomeType.ChangeAttackType) continue;

                ApplyOutcome(outcome, action.SourcePlayer, action.tokenData);
            }
        }
    }

    private void ApplyOutcome(StatusOutcome outcome, PlayerController source, StatusEffectsData tokenData)
    {
        var bm = BattleManager.Instance;
        PlayerController target = (outcome.target == StatusTarget.Opponent) ? bm.opponentPlayer : source;

        switch (outcome.type)
        {
            case OutcomeType.TakeBonusORP:
                bm.hasBonusOffensivePhase = true;
                break;

            case OutcomeType.ChangeAttackType:
                // base logic for Invisibility
                if (tokenData.effectName == "Invisibility" && bm.currentPhase == TurnPhase.DefensiveRollPhase)
                {
                    Debug.Log("[StatusResolver] INVISIBILITY used! Removing Undefendable restriction for this phase.");
                    bm.canActivateDefensiveAbility = true;
                    
                    bm.NotifyPhase("Invisibility active! Defensive Abilities are now allowed.");
                    
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
            
            case OutcomeType.Damage:
                target.ChangeHealth(-(int)outcome.value);
                break;
            case OutcomeType.Healing:
                target.ChangeHealth((int)outcome.value);
                break;
            case OutcomeType.GainCP:
                target.ChangeCP((int)outcome.value);
                break;
            case OutcomeType.DrawCard:
                target.DrawCards(Mathf.CeilToInt(outcome.value));
                break;
            case OutcomeType.Prevent:
                bm.AddTurnPrevention(outcome.value);
                Debug.Log($"[StatusResolver] {tokenData.effectName} adds {outcome.value} damage prevention.");
                bm.NotifyPhase($"{tokenData.effectName} active! Prevents {outcome.value} damage.");
                break;
        }
    }
}