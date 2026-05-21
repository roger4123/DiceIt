using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} played '{card.cardName}'.", new Color(0.9f, 0.5f, 1f));

        if (ActionStackManager.Instance != null)
        {
            ActionStackManager.Instance.ResetPriorityPasses();
        }

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

        // After a card resolves, re-evaluate the dice interaction state based on who has priority.
        ActionStackManager.Instance.ReassertPriority();
        
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
            BattleManager.Instance?.NotifyPhase("Click on a player's Token Pool to select them.");
            bool targetSelected = false;
            UI_TokensPoolModal.Instance.RequestPlayerSelection((p) => {
                target = p;
                targetSelected = true;
            });
            yield return new WaitUntil(() => targetSelected);
            BattleManager.Instance?.NotifyPhase("");
        }
        else if (effect.targetMode == CardTargetMode.SourceToDestination)
        {
            BattleManager.Instance?.NotifyPhase("Click on the SOURCE player's Token Pool.");
            bool sourceSelected = false;
            UI_TokensPoolModal.Instance.RequestPlayerSelection((p) => {
                target = p;
                sourceSelected = true;
            });
            yield return new WaitUntil(() => sourceSelected);
            BattleManager.Instance?.NotifyPhase("");
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
                {
                    // if the effect is scaling (roll x to gain), the calculated finalValue determines the amount
                    // else: use the amount defined in the CardData
                    int amountToAdd = effect.isScaling ? Mathf.CeilToInt(finalValue) : statusApp.amount;
                    target.AddStatus(statusApp.status, amountToAdd);
                }
                break;
                
            case CardActionType.RemoveStatus:
                if (effect.value == 0 || effect.value == -1) 
                {
                    target.ClearAllStatuses();
                    UI_CombatLog.Instance?.LogMessage($"{target.characterData.heroName} was cleansed of all status effects.", Color.white);
                }
                else 
                {
                    int totalTokens = BattleManager.Instance.player1.activeStatuses.Count + BattleManager.Instance.player2.activeStatuses.Count;
                    if (totalTokens == 0)
                    {
                        UI_CombatLog.Instance?.LogMessage("No tokens on the board to remove.", Color.gray);
                        break;
                    }

                    bool effectResolved = false;
                    while (!effectResolved)
                    {
                        BattleManager.Instance?.NotifyPhase($"Select a token to remove from {target.characterData.heroName}.");
                        bool selectionDone = false;
                        StatusEffectsData chosenToken = null;
                        
                        UI_TokensPoolModal.Instance.RequestTokenSelection(target, (token) => {
                            chosenToken = token;
                            selectionDone = true;
                        });
                        
                        yield return new WaitUntil(() => selectionDone);

                        if (chosenToken != null)
                        {
                            target.RemoveStatus(chosenToken, Mathf.Max(1, Mathf.CeilToInt(finalValue)));
                            UI_CombatLog.Instance?.LogMessage($"Removed 1 {chosenToken.effectName} from {target.characterData.heroName}.", Color.white);
                            effectResolved = true;
                        }
                        else
                        {
                            BattleManager.Instance?.NotifyPhase("Click on a player's Token Pool to select them.");
                            bool targetSelected = false;
                            UI_TokensPoolModal.Instance.RequestPlayerSelection((p) => {
                                target = p;
                                targetSelected = true;
                            });
                            yield return new WaitUntil(() => targetSelected);
                        }
                    }
                    BattleManager.Instance?.NotifyPhase("");
                }
                break;
                
            case CardActionType.TransferStatus:
            {
                int totalTransferable = BattleManager.Instance.player1.activeStatuses.Count(s => s.data.isTransferable) + BattleManager.Instance.player2.activeStatuses.Count(s => s.data.isTransferable);
                if (totalTransferable == 0)
                {
                    UI_CombatLog.Instance?.LogMessage("No transferable tokens on the board.", Color.gray);
                    break;
                }

                PlayerController dest = (target == BattleManager.Instance.player1) ? BattleManager.Instance.player2 : BattleManager.Instance.player1;

                bool effectResolved = false;
                while (!effectResolved)
                {
                    BattleManager.Instance?.NotifyPhase($"Select a token to transfer from {target.characterData.heroName}.");
                    bool transferSelectionDone = false;
                    StatusEffectsData tokenToTransfer = null;

                    UI_TokensPoolModal.Instance.RequestTokenSelection(target, (token) => {
                        tokenToTransfer = token;
                        transferSelectionDone = true;
                    });

                    yield return new WaitUntil(() => transferSelectionDone);

                    if (tokenToTransfer != null)
                    {
                        if (tokenToTransfer.isTransferable)
                        {
                            target.RemoveStatus(tokenToTransfer, 1);
                            dest.AddStatus(tokenToTransfer, 1);
                            UI_CombatLog.Instance?.LogMessage($"Transferred {tokenToTransfer.effectName} from {target.characterData.heroName} to {dest.characterData.heroName}.", Color.magenta);
                            effectResolved = true;
                        }
                        else 
                        {
                            UI_CombatLog.Instance?.LogMessage($"{tokenToTransfer.effectName} cannot be transferred!", Color.red);
                        }
                    }
                    else
                    {
                        // Ne-am răzgândit la token! Alegem alt jucător sursă.
                        BattleManager.Instance?.NotifyPhase("Click on the SOURCE player's Token Pool.");
                        bool sourceSelected = false;
                        UI_TokensPoolModal.Instance.RequestPlayerSelection((p) => {
                            target = p;
                            dest = (target == BattleManager.Instance.player1) ? BattleManager.Instance.player2 : BattleManager.Instance.player1;
                            sourceSelected = true;
                        });
                        yield return new WaitUntil(() => sourceSelected);
                    }
                }
                BattleManager.Instance?.NotifyPhase("");
                break;
            }

            // === ROLL PHASE & DICE ACTIONS ===
            case CardActionType.ChangeDiceValueToSix:
            {
                Debug.Log("[CardResolver] BREAK: Select one of your dice to make 6.");
                bool selectionDone = false;
                int chosenDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { chosenDie = idx; selectionDone = true; });
                yield return new WaitUntil(() => selectionDone);
                DiceManager.Instance.SetDieValue(chosenDie, 6);
                break;
            }

            case CardActionType.ChangeDiceValueIdenticalToAnother:
            {
                BattleManager.Instance?.NotifyPhase("Select the die you want to CHANGE.");
                bool destSelected = false;
                int destDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { destDie = idx; destSelected = true; });
                yield return new WaitUntil(() => destSelected);

                BattleManager.Instance?.NotifyPhase("Select the die to COPY the value from.");
                bool sourceSelected = false;
                int sourceDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { sourceDie = idx; sourceSelected = true; });
                yield return new WaitUntil(() => sourceSelected);

                int copiedValue = DiceManager.Instance.dice[sourceDie].currentValue;
                DiceManager.Instance.SetDieValue(destDie, copiedValue);
                BattleManager.Instance?.NotifyPhase("");
                break;
            }

            case CardActionType.ChangeDiceValue:
            {
                int timesToChange = Mathf.Max(1, Mathf.CeilToInt(finalValue));
                for (int i = 0; i < timesToChange; i++)
                {
                    BattleManager.Instance?.NotifyPhase($"Select die to change ({i + 1}/{timesToChange}).");
                    bool selected = false;
                    int pickedDie = -1;
                    DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { pickedDie = idx; selected = true; });
                    yield return new WaitUntil(() => selected);
                    
                    bool faceSelected = false;
                    int chosenFace = -1;
                    
                    List<int> validFaces = new List<int> { 1, 2, 3, 4, 5, 6 };
                    
                    UI_DiceFaceSelector.Instance.Show(rollingPlayer, validFaces, (face) => {
                        chosenFace = face;
                        faceSelected = true;
                    });
                    
                    yield return new WaitUntil(() => faceSelected);
                    
                    if (chosenFace != -1)
                    {
                        DiceManager.Instance.SetDieValue(pickedDie, chosenFace);
                        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} changed a die to {chosenFace}.", Color.white);
                    }
                    else
                    {
                        i--;
                    }
                }
                BattleManager.Instance?.NotifyPhase("");
                break;
            }

            case CardActionType.IncrementOrDecrement:
            {
                int timesToChange = Mathf.Max(1, Mathf.CeilToInt(finalValue));
                for (int i = 0; i < timesToChange; i++)
                {
                    BattleManager.Instance?.NotifyPhase("Select die to increase/decrease.");
                    bool selected = false;
                    int pickedDie = -1;
                    DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { pickedDie = idx; selected = true; });
                    yield return new WaitUntil(() => selected);
                    
                    int originalVal = DiceManager.Instance.dice[pickedDie].currentValue;
                    List<int> validFaces = new List<int>();
                    if (originalVal > 1) validFaces.Add(originalVal - 1);
                    if (originalVal < 6) validFaces.Add(originalVal + 1);

                    bool faceSelected = false;
                    int chosenFace = -1;
                    UI_DiceFaceSelector.Instance.Show(rollingPlayer, validFaces, (face) => {
                        chosenFace = face;
                        faceSelected = true;
                    });
                    yield return new WaitUntil(() => faceSelected);
                    
                    if (chosenFace != -1) 
                    {
                        DiceManager.Instance.SetDieValue(pickedDie, chosenFace);
                        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} tipped a die to {chosenFace}.", Color.white);
                    }
                    else i--;
                }
                BattleManager.Instance?.NotifyPhase("");
                break;
            }

            case CardActionType.RerollDice:
            {
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
            }

            case CardActionType.ForceOpponentReroll:
            {
                Debug.Log("[CardResolver] BREAK: Select an opponent's die to force reroll.");
                bool oppSelected = false;
                int oppPickedDie = -1;
                DiceManager.Instance.RequestDieSelection(rollingPlayer, (idx, p) => { oppPickedDie = idx; oppSelected = true; });
                yield return new WaitUntil(() => oppSelected);
                
                DiceManager.Instance.ForceRerollDie(oppPickedDie);
                yield return new WaitForSeconds(0.5f);
                break;
            }

            case CardActionType.AddRollAttempt:
                Debug.Log("[CardResolver] ROLL PHASE RESET!");
                if (BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase)
                {
                    DiceManager.Instance.ResetDice(3, 5);
                }
                else if (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase)
                {
                    int dCount = BattleManager.Instance.pendingDefenseSelection != null ? BattleManager.Instance.pendingDefenseSelection.diceToRoll : 0;
                    DiceManager.Instance.ResetDice(1, dCount); 
                }
                BattleManager.Instance.hasActivatedAbilityThisPhase = false;
                break;
                
            // === COMBAT ACTIONS (Resolution Phase) ===
            case CardActionType.PreventDamage:
                if (BattleManager.Instance != null)
                {
                    BattleManager.Instance.AddTurnPrevention(finalValue);
                }
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
        {
            int amountToAdd = effect.isScaling ? Mathf.CeilToInt(finalValue) : statusApp.amount;
            target.AddStatus(statusApp.status, amountToAdd);
        }

        yield return null;
    }
}