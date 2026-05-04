using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardResolver : MonoBehaviour
{
    public static CardResolver Instance;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void PlayCard(CardData card, PlayerController owner)
    {
        owner.ChangeCP(-card.cpCost);
        owner.DiscardCard(card);

        StartCoroutine(ResolveCardRoutine(card, owner));
    }

    public void SellCard(CardData card, PlayerController owner)
    {
        owner.ChangeCP(1);
        owner.DiscardCard(card);
        Debug.Log($"{owner.characterData.heroName} sold {card.cardName} for 1 CP.");
    }

    private IEnumerator ResolveCardRoutine(CardData card, PlayerController owner)
    {
        Debug.Log($"[CardResolver] Resolving card: {card.cardName}...");

        if (card.cardType == CardType.Upgrade)
        {
            owner.ApplyUpgrade(card.abilityToUpgrade, card.upgradedAbilityVersion);
            yield break;
        }

        // standard effects
        foreach (var effect in card.cardEffects)
        {
            yield return StartCoroutine(ResolveOutcomeRoutine(effect, owner));
        }

        // secondary rolls (if they exist)
        if (card.cardRolls != null && card.cardRolls.Count > 0)
        {
            Debug.Log($"[CardResolver] Card needs {card.cardRolls.Count} secondary rolls.");
            
            foreach (var secRoll in card.cardRolls)
            {
                int amountToRoll = secRoll.diceCount; 
                
                DiceManager.Instance.ResetDice(1, amountToRoll);
                yield return new WaitForSeconds(0.5f);
                
                DiceManager.Instance.RollDice();
                yield return new WaitForSeconds(1.5f);

                List<int> rolledValues = DiceManager.Instance.GetCurrentDiceValues();
                int sum = 0;
                foreach (int v in rolledValues) sum += v;
                
                Debug.Log($"[CardResolver] Thrown dice: {amountToRoll}. Total sum: {sum}");

                foreach (var outcome in secRoll.outcomes)
                {
                    yield return StartCoroutine(ResolveOutcomeRoutine(outcome, owner, sum));
                }
                
                DiceManager.Instance.ResetDice(0, 0); 
            }
        }

        // resseting interaction state after playing a card
        if (BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase ||
            BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase)
        {
            DiceManager.Instance.SetInteractionState(DiceInteractionState.PlayerLocking);
        }
        else
        {
            DiceManager.Instance.SetInteractionState(DiceInteractionState.Disabled);
        }

        Debug.Log($"[CardResolver] {card.cardName} was resolved successfully!");
        yield return null;
    }

    // coroutine for processing a single outcome (with optional scaling multiplier, ex: the sum of dice)
    private IEnumerator ResolveOutcomeRoutine(CardOutcome effect, PlayerController owner, int scalingMultiplier = 1)
    {
        PlayerController target = owner;
        PlayerController opponent = (BattleManager.Instance.activePlayer == owner) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer;
        PlayerController rollingPlayer = (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase) 
                                         ? BattleManager.Instance.opponentPlayer 
                                         : BattleManager.Instance.activePlayer;

        // --- TARGETING LOGIC ---
        if (effect.targetMode == CardTargetMode.Opponent)
        {
            target = opponent;
        }
        else if (effect.targetMode == CardTargetMode.ChosenPlayer)
        {
            Debug.Log("[CardResolver] BREAK: Choose the target.");
            // TODO: UI_TargetModal. 
            // oponentul by default pentru testare.
            yield return new WaitForSeconds(1f);
            target = opponent; 
        }
        else if (effect.targetMode == CardTargetMode.SourceToDestination)
        {
            Debug.Log("[CardResolver] BREAK: Select Source.");
            // TODO: who gives to whom
        }

        // --- CONDITION LOGIC ---
        if (effect.condition != CardConditionType.None)
        {
            bool conditionMet = true;
            switch (effect.condition)
            {
                case CardConditionType.WhenAttacked:
                    Debug.Log("[CardResolver] Checking 'WhenAttacked' condition...");
                    // TODO: verif istoricul din BattleManager pentru a vedea daca preventul a avut succes
                    break;
                case CardConditionType.OnOffensiveRoll:
                    conditionMet = BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase;
                    break;
                case CardConditionType.OnDefensiveRoll:
                    conditionMet = BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase;
                    break;
            }

            if (!conditionMet) {
                Debug.Log($"[CardResolver] Condition {effect.condition} was NOT fulfilled. Canceling the effect.");
                yield break;
            }
        }

        float finalValue = effect.value;
        if (effect.isScaling)
        {
            finalValue = effect.value * scalingMultiplier;
            Debug.Log($"[CardResolver] SCALING effect applied: {effect.value} x {scalingMultiplier} (Multiplicator) = {finalValue}");
        }

        // --- ACTION LOGIC ---
        switch (effect.actionType)
        {
            case CardActionType.GainCP:
                target.ChangeCP(Mathf.CeilToInt(finalValue));
                break;
                
            case CardActionType.Heal:
                target.ChangeHealth(Mathf.CeilToInt(finalValue));
                break;
                
            case CardActionType.Damage:
                target.ChangeHealth(-Mathf.CeilToInt(finalValue));
                break;
                
            case CardActionType.DrawCard:
                target.DrawCards(Mathf.CeilToInt(finalValue));
                break;
                
            case CardActionType.GainStatus:
                foreach (var statusApp in effect.statuses)
                    target.AddStatus(statusApp.status, statusApp.amount);
                break;
                
            case CardActionType.RemoveStatus:
                if (effect.value == 0 || effect.value == -1) target.ClearAllStatuses();
                else 
                {
                    Debug.Log("[CardResolver] Choose which Status Effect to be removed...");
                    // TODO: verif lista de statusuri de pe target pentru alegere
                }
                break;
                
            // === ROLL PHASE & DICE ACTIONS ===
            case CardActionType.ChangeDiceValueToSix:
                Debug.Log("[CardResolver] BREAK: Select one of your dice to make 6.");
                bool selectionDone = false;
                int chosenDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { chosenDie = idx; selectionDone = true; });
                yield return new WaitUntil(() => selectionDone);
                DiceManager.Instance.SetDieValue(chosenDie, 6);
                break;

            case CardActionType.ChangeDiceValueIdenticalToAnother:
                Debug.Log("[CardResolver] BREAK: Select the source die and the destination die for chaning.");
                bool sourceSelected = false;
                int sourceDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { sourceDie = idx; sourceSelected = true; });
                yield return new WaitUntil(() => sourceSelected);

                Debug.Log("[CardResolver] BREAK: Select the DESTINATION die for changing.");
                bool destSelected = false;
                int destDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { destDie = idx; destSelected = true; });
                yield return new WaitUntil(() => destSelected);

                int copiedValue = DiceManager.Instance.dice[sourceDie].currentValue;
                DiceManager.Instance.SetDieValue(destDie, copiedValue);
                break;

            case CardActionType.ChangeDiceValue:
                int timesToChange = Mathf.Max(1, Mathf.CeilToInt(finalValue));
                for (int i = 0; i < timesToChange; i++)
                {
                    Debug.Log($"[CardResolver] BREAK: Select di(c)e ({i + 1}/{timesToChange}) and its new value.");
                    bool selected = false;
                    int pickedDie = -1;
                    DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { pickedDie = idx; selected = true; });
                    yield return new WaitUntil(() => selected);
                    
                    // TODO: UI pentru a alege nr.
                    DiceManager.Instance.SetDieValue(pickedDie, 5);
                }
                break;

            case CardActionType.RerollDice:
                int timesToReroll = Mathf.Max(1, Mathf.CeilToInt(finalValue));
                for (int i = 0; i < timesToReroll; i++)
                {
                    Debug.Log($"[CardResolver] BREAK: Select di(c)e to reroll ({i + 1}/{timesToReroll})...");
                    bool selected = false;
                    int pickedDie = -1;
                    DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { pickedDie = idx; selected = true; });
                    yield return new WaitUntil(() => selected);
                    
                    DiceManager.Instance.ForceRerollDie(pickedDie);
                    yield return new WaitForSeconds(0.5f);
                }
                break;

            case CardActionType.ForceOpponentReroll:
                Debug.Log("[CardResolver] BREAK: Select an opponent's die to force reroll.");
                bool oppSelected = false;
                int oppPickedDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { oppPickedDie = idx; oppSelected = true; });
                yield return new WaitUntil(() => oppSelected);
                
                DiceManager.Instance.ForceRerollDie(oppPickedDie);
                yield return new WaitForSeconds(0.5f);
                break;

            case CardActionType.AddRollAttempt:
                Debug.Log("[CardResolver] ROLL PHASE RESET!");
                if (BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase)
                {
                    DiceManager.Instance.ResetDice(3, 5);
                }
                else if (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase)
                {
                    int dCount = BattleManager.Instance.pendingDefenseSelection != null ? BattleManager.Instance.pendingDefenseSelection.diceToRoll : 0;
                    DiceManager.Instance.ResetDice(3, dCount); 
                }
                BattleManager.Instance.hasActivatedAbilityThisPhase = false;
                break;
                
            // === COMBAT ACTIONS (Resolution Phase) ===
            case CardActionType.PreventDamage:
                Debug.Log($"[CardResolver] Player {target.characterData.heroName} prevents {finalValue} DMG!");
                // TODO: de stocat valoarea intr-o variabila pe PlayerController pentru Resolution Phase
                break;
                
            case CardActionType.SwapRequiredSymbols:
                Debug.Log("[CardResolver] Swapping required symbols!");
                // TODO: inlocuire temporara a cerintei de validare in AbilityMatcher
                break;

            default:
                Debug.LogWarning($"[CardResolver] Action Type {effect.actionType} unknown!");
                break;
        }
    }

    // Overload for processing an AbilityOutcome (internally used in SecondaryRolls)
    private IEnumerator ResolveOutcomeRoutine(AbilityOutcome effect, PlayerController owner, int scalingMultiplier = 1)
    {
        PlayerController target = owner;
        if (effect.target.ToString() == "Opponent")
        {
            target = (BattleManager.Instance.activePlayer == owner) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer;
        }

        float finalValue = effect.value;
        if (effect.isScaling)
        {
            finalValue = effect.value * scalingMultiplier;
            Debug.Log($"[CardResolver] SCALING effect applied: {effect.value} x {scalingMultiplier} (Multiplicator) = {finalValue}");
        }

        switch (effect.type)
        {
            case OutcomeType.GainCP:
                target.ChangeCP(Mathf.CeilToInt(finalValue));
                break;
            case OutcomeType.Healing:
                target.ChangeHealth(Mathf.CeilToInt(finalValue));
                break;
            case OutcomeType.Damage:
                target.ChangeHealth(-Mathf.CeilToInt(finalValue));
                break;
        }
        
        foreach (var statusApp in effect.statuses)
            target.AddStatus(statusApp.status, statusApp.amount);

        yield return null;
    }
}