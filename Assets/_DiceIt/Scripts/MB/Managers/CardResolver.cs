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
        
        // "banish" the upgrades so they don't ever return in hand
        if (card.cardType != CardType.Upgrade)
        {
            UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} played '{card.cardName}'.", Color.black);
            owner.DiscardCard(card);
        }
        else
        {
            owner.BanishCard(card);
        }
        

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
        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} sold {card.cardName} for 1 CP.", Color.black);
    }

    private IEnumerator ResolveCardRoutine(CardData card, PlayerController owner)
    {
        Debug.Log($"[CardResolver] Resolving card: {card.cardName}...");

        if (card.cardType == CardType.Upgrade)
        {
            owner.ApplyUpgrade(card.abilityToUpgrade, card.upgradedAbilityVersion);       
            ActionStackManager.Instance.ReassertPriority();
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
            UI_CombatLog.Instance?.LogMessage($"Card '{card.cardName}' needs {card.cardRolls.Count} secondary rolls.", Color.black);
            
            if (BattleManager.Instance != null) BattleManager.Instance.isPerformingSpecialRoll = true;
            DiceManager.Instance.StoreDiceState();

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
                string rolledValuesStr = string.Join(", ", rolledValues.Where(v => v > 0));
                UI_CombatLog.Instance?.LogMessage($"Thrown values: {rolledValuesStr} - from {amountToRoll} dice. Total sum: {sum}", Color.black);

                foreach (var outcome in secRoll.outcomes)
                {
                    if (AbilityResolver.Instance != null && AbilityResolver.Instance.IsConditionMet(outcome, rolledValues, owner.characterData.diceKey, out float scalingMult))
                    {
                        yield return StartCoroutine(ResolveOutcomeRoutine(outcome, owner, scalingMult));
                    }
                }
            }

            DiceManager.Instance.RestoreDiceState();
            yield return new WaitForSeconds(0.5f);
            if (BattleManager.Instance != null) BattleManager.Instance.isPerformingSpecialRoll = false;
        }

        // after a card resolves, re-evaluate the dice interaction state based on who has priority
        ActionStackManager.Instance.ReassertPriority();
        
        Debug.Log($"[CardResolver] {card.cardName} was resolved successfully!");
        UI_CombatLog.Instance?.LogMessage($"{card.cardName} was resolved successfully!", Color.black);
        BattleManager.Instance?.ShowNotification($"{card.cardName} resolved!", 1.5f);
        yield return null;
    }

    // coroutine for processing a single outcome (with optional scaling multiplier, ex: the sum of dice)
    private IEnumerator ResolveOutcomeRoutine(CardOutcome effect, PlayerController owner, int scalingMultiplier = 1)
    {
        PlayerController target = owner;
        PlayerController opponent = (BattleManager.Instance.activePlayer == owner) 
                                    ? BattleManager.Instance.opponentPlayer 
                                    : BattleManager.Instance.activePlayer;
        PlayerController rollingPlayer = (BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase) 
                                         ? BattleManager.Instance.opponentPlayer 
                                         : BattleManager.Instance.activePlayer;

        bool isDiceAction = effect.actionType == CardActionType.ChangeDiceValue || 
                            effect.actionType == CardActionType.RerollDice || 
                            effect.actionType == CardActionType.ForceOpponentReroll || 
                            effect.actionType == CardActionType.ChangeDiceValueIdenticalToAnother || 
                            effect.actionType == CardActionType.ChangeDiceValueToSix || 
                            effect.actionType == CardActionType.IncrementOrDecrement;

        // --- TARGETING LOGIC ---
        if (effect.targetMode == CardTargetMode.Opponent)
        {
            target = opponent;
        }
        else if (effect.targetMode == CardTargetMode.ChosenPlayer)
        {
            if (owner.isAI)
            {
                target = AIManager.Instance.ChoosePlayerTarget(effect, owner);
            }
            else
            {
                bool validTargetSelected = false;
                while (!validTargetSelected)
                {
                    BattleManager.Instance?.NotifyPhase("Click on a player's Token Pool to select them.");
                    bool targetSelected = false;
                    UI_TokensPoolModal.Instance.RequestPlayerSelection((p) => {
                        target = p;
                        targetSelected = true;
                    });
                    yield return new WaitUntil(() => targetSelected);
                    
                    if (isDiceAction && target != rollingPlayer)
                    {
                        UI_CombatLog.Instance?.LogMessage("The selected player doesn't have any rolled dice!", Color.black);
                    }
                    else
                    {
                        validTargetSelected = true;
                    }
                }
                BattleManager.Instance?.NotifyPhase("");
            }
        }
        else if (effect.targetMode == CardTargetMode.SourceToDestination)
        {
            if (owner.isAI)
            {
                target = AIManager.Instance.ChoosePlayerTarget(effect, owner);
            }
            else
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
        }

        // --- CONDITION LOGIC ---
        float localScalingMult = scalingMultiplier;
        
        if (effect.condition != CardConditionType.None)
        {
            bool conditionMet = true;
            switch (effect.condition)
            {
                case CardConditionType.WhenAttacked:
                    conditionMet = BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase &&
                                   BattleManager.Instance.opponentPlayer == owner &&
                                   BattleManager.Instance.committedOffense != null;
                    break;
                case CardConditionType.OnOffensiveRoll:
                    conditionMet = BattleManager.Instance.currentPhase == TurnPhase.OffensiveRollPhase;
                    break;
                case CardConditionType.OnDefensiveRoll:
                    conditionMet = BattleManager.Instance.currentPhase == TurnPhase.DefensiveRollPhase;
                    break;
                case CardConditionType.DiscardStatus:
                    StatusEffectsData reqStatus = effect.statusRequirement;
                    if (reqStatus == null && effect.statuses != null && effect.statuses.Count > 0)
                        reqStatus = effect.statuses[0].status; // fallback for spider-man
                        
                    if (reqStatus != null)
                    {
                        var existing = owner.activeStatuses.FirstOrDefault(s => s.data == reqStatus);
                        int cost = effect.discardAmount > 0 ? effect.discardAmount : 1;
                        
                        if (existing != null && existing.currentStacks >= cost)
                        {
                            owner.RemoveStatus(reqStatus, cost);
                            UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} discarded {cost} {reqStatus.effectName}.", Color.black);
                            conditionMet = true;
                        }
                        else
                        {
                            UI_CombatLog.Instance?.LogMessage($"Card failed: Missing {reqStatus.effectName} token!", Color.black);
                            conditionMet = false;
                        }
                    }
                    else conditionMet = false;
                    break;
                    
                case CardConditionType.StatusStacksScaling:
                    if (effect.statusRequirement != null)
                    {
                        var existing = owner.activeStatuses.FirstOrDefault(s => s.data == effect.statusRequirement);
                        localScalingMult = existing != null ? existing.currentStacks : 0;
                        conditionMet = localScalingMult > 0;
                    }
                    else conditionMet = false;
                    break;
            }

            if (!conditionMet) {
                Debug.Log($"[CardResolver] Condition {effect.condition} was NOT fulfilled. Canceling the effect.");
                UI_CombatLog.Instance?.LogMessage($"Card condition {effect.condition} not met. Effect canceled.", Color.black);
                yield break;
            }
        }

        float finalValue = effect.value;
        if (effect.isScaling)
        {
            finalValue = effect.value * localScalingMult;
            Debug.Log($"[CardResolver] SCALING effect applied: {effect.value} x {localScalingMult} (Multiplicator) = {finalValue}");
            UI_CombatLog.Instance?.LogMessage($"Scaling effect applied! Total: {finalValue}", Color.black);
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
                }
                else 
                {
                    int totalTokens = BattleManager.Instance.player1.activeStatuses.Count + BattleManager.Instance.player2.activeStatuses.Count;
                    if (totalTokens == 0)
                    {
                        UI_CombatLog.Instance?.LogMessage("No tokens on the board to remove.", Color.black);
                        break;
                    }

                    bool effectResolved = false;
                    while (!effectResolved)
                    {
                        StatusEffectsData chosenToken = null;
                        
                        if (owner.isAI)
                        {
                            chosenToken = AIManager.Instance.ChooseTokenTarget(target, effect.actionType);
                            yield return new WaitForSeconds(1.0f);
                        }
                        else
                        {
                            BattleManager.Instance?.NotifyPhase($"Select a token to remove from {target.characterData.heroName}.");
                            bool selectionDone = false;
                            UI_TokensPoolModal.Instance.RequestTokenSelection(target, (token) => {
                                chosenToken = token;
                                selectionDone = true;
                            });
                            yield return new WaitUntil(() => selectionDone);
                        }

                        if (chosenToken != null)
                        {
                            target.RemoveStatus(chosenToken, Mathf.Max(1, Mathf.CeilToInt(finalValue)));
                            UI_CombatLog.Instance?.LogMessage($"Removed 1 {chosenToken.effectName} from {target.characterData.heroName}.", Color.black);
                            effectResolved = true;
                        }
                        else
                        {
                            if (owner.isAI)
                            {
                                target = AIManager.Instance.ChoosePlayerTarget(effect, owner);
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
                    }
                    BattleManager.Instance?.NotifyPhase("");
                }
                break;
                
            case CardActionType.TransferStatus:
            {
                int totalTransferable = BattleManager.Instance.player1.activeStatuses.Count(s => s.data.isTransferable) + BattleManager.Instance.player2.activeStatuses.Count(s => s.data.isTransferable);
                if (totalTransferable == 0)
                {
                    UI_CombatLog.Instance?.LogMessage("No transferable tokens on the board.", Color.black);
                    break;
                }

                PlayerController dest = (target == BattleManager.Instance.player1) ? BattleManager.Instance.player2 : BattleManager.Instance.player1;

                bool effectResolved = false;
                while (!effectResolved)
                {
                    StatusEffectsData tokenToTransfer = null;

                    if (owner.isAI)
                    {
                        tokenToTransfer = AIManager.Instance.ChooseTokenTarget(target, effect.actionType);
                        yield return new WaitForSeconds(1.0f);
                    }
                    else
                    {
                        BattleManager.Instance?.NotifyPhase($"Select a token to transfer from {target.characterData.heroName}.");
                        bool transferSelectionDone = false;
                        UI_TokensPoolModal.Instance.RequestTokenSelection(target, (token) => {
                            tokenToTransfer = token;
                            transferSelectionDone = true;
                        });
                        yield return new WaitUntil(() => transferSelectionDone);
                    }

                    if (tokenToTransfer != null)
                    {
                        if (tokenToTransfer.isTransferable)
                        {
                            target.RemoveStatus(tokenToTransfer, 1);
                            dest.AddStatus(tokenToTransfer, 1);
                            UI_CombatLog.Instance?.LogMessage($"Transferred {tokenToTransfer.effectName} from {target.characterData.heroName} to {dest.characterData.heroName}.", Color.black);
                            effectResolved = true;
                        }
                        else 
                        {
                            UI_CombatLog.Instance?.LogMessage($"{tokenToTransfer.effectName} cannot be transferred!", Color.black);
                        }
                    }
                    else
                    {
                        if (owner.isAI)
                        {
                            target = AIManager.Instance.ChoosePlayerTarget(effect, owner);
                            dest = (target == BattleManager.Instance.player1) ? BattleManager.Instance.player2 : BattleManager.Instance.player1;
                        }
                        else
                        {
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
                }
                BattleManager.Instance?.NotifyPhase("");
                break;
            }

            // === ROLL PHASE & DICE ACTIONS ===
            case CardActionType.ChangeDiceValueToSix:
            {
                int chosenDie = -1;
                
                if (owner.isAI)
                {
                    chosenDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                    yield return new WaitForSeconds(1.0f);
                }
                else
                {
                    Debug.Log("[CardResolver] BREAK: Select one of your dice to make 6.");
                    BattleManager.Instance?.ShowNotification("Select one of your dice to make 6.", 2.5f);
                    bool selectionDone = false;
                    DiceManager.Instance.RequestDieSelection(target, (idx, p) => { chosenDie = idx; selectionDone = true; });
                    yield return new WaitUntil(() => selectionDone);
                }

                DiceManager.Instance.SetDieValue(chosenDie, 6);
                break;
            }

            case CardActionType.ChangeDiceValueIdenticalToAnother:
            {
                int destDie = -1;
                int sourceDie = -1;

                if (owner.isAI)
                {
                    destDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                    yield return new WaitForSeconds(1.0f);
                }
                else
                {
                    BattleManager.Instance?.NotifyPhase("Select the die you want to CHANGE.");
                    bool destSelected = false;
                    DiceManager.Instance.RequestDieSelection(target, (idx, p) => { destDie = idx; destSelected = true; });
                    yield return new WaitUntil(() => destSelected);
                }

                if (owner.isAI)
                {
                    sourceDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                    yield return new WaitForSeconds(1.0f);
                }
                else
                {
                    BattleManager.Instance?.NotifyPhase("Select the die to COPY the value from.");
                    bool sourceSelected = false;
                    DiceManager.Instance.RequestDieSelection(target, (idx, p) => { sourceDie = idx; sourceSelected = true; });
                    yield return new WaitUntil(() => sourceSelected);
                }

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
                    int pickedDie = -1;
                    int chosenFace = -1;
                    List<int> validFaces = new List<int> { 1, 2, 3, 4, 5, 6 };

                    if (owner.isAI)
                    {
                        pickedDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                        yield return new WaitForSeconds(1.0f);
                    }
                    else
                    {
                        BattleManager.Instance?.NotifyPhase($"Select die to change ({i + 1}/{timesToChange}).");
                        bool selected = false;
                        DiceManager.Instance.RequestDieSelection(target, (idx, p) => { pickedDie = idx; selected = true; });
                        yield return new WaitUntil(() => selected);
                    }
                    
                    if (owner.isAI)
                    {
                        chosenFace = AIManager.Instance.ChooseDiceFace(target, validFaces, effect.actionType);
                        yield return new WaitForSeconds(0.5f);
                    }
                    else
                    {
                        bool faceSelected = false;
                        UI_DiceFaceSelector.Instance.Show(rollingPlayer, validFaces, (face) => {
                            chosenFace = face;
                            faceSelected = true;
                        });
                        yield return new WaitUntil(() => faceSelected);
                    }
                    
                    if (chosenFace != -1)
                    {
                        DiceManager.Instance.SetDieValue(pickedDie, chosenFace);
                        string diceStr = string.Join(", ", DiceManager.Instance.GetCurrentDiceValues().Where(v => v > 0));
                        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} changed a die to {chosenFace}. Current dice: {diceStr}", Color.black);
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
                    int pickedDie = -1;
                    int chosenFace = -1;
                    

                    if (owner.isAI)
                    {
                        pickedDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                        yield return new WaitForSeconds(1.0f);
                    }
                    else
                    {
                        BattleManager.Instance?.NotifyPhase("Select die to increase/decrease.");
                        bool selected = false;
                        DiceManager.Instance.RequestDieSelection(target, (idx, p) => { pickedDie = idx; selected = true; });
                        yield return new WaitUntil(() => selected);
                    }

                    int originalVal = DiceManager.Instance.dice[pickedDie].currentValue;
                    List<int> validFaces = new List<int>();
                    if (originalVal > 1) validFaces.Add(originalVal - 1);
                    if (originalVal < 6) validFaces.Add(originalVal + 1);
                    
                    if (owner.isAI)
                    {
                        chosenFace = AIManager.Instance.ChooseDiceFace(target, validFaces, effect.actionType);
                        yield return new WaitForSeconds(0.5f);
                    }
                    else
                    {
                        bool faceSelected = false;
                        UI_DiceFaceSelector.Instance.Show(rollingPlayer, validFaces, (face) => {
                            chosenFace = face;
                            faceSelected = true;
                        });
                        yield return new WaitUntil(() => faceSelected);
                    }
                    
                    if (chosenFace != -1) 
                    {
                        DiceManager.Instance.SetDieValue(pickedDie, chosenFace);
                        string diceStr = string.Join(", ", DiceManager.Instance.GetCurrentDiceValues().Where(v => v > 0));
                        UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName} tipped a die to {chosenFace}. Current dice: {diceStr}", Color.black);
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
                    int pickedDie = -1;

                    if (owner.isAI)
                    {
                        pickedDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                        yield return new WaitForSeconds(1.0f);
                    }
                    else
                    {
                        Debug.Log($"[CardResolver] BREAK: Select di(c)e to reroll ({i + 1}/{timesToReroll})...");
                        BattleManager.Instance?.ShowNotification($"Select die to reroll ({i + 1}/{timesToReroll}).", 2.5f);
                        bool selected = false;
                        DiceManager.Instance.RequestDieSelection(target, (idx, p) => { pickedDie = idx; selected = true; });
                        yield return new WaitUntil(() => selected);
                    }
                    
                    DiceManager.Instance.ForceRerollDie(pickedDie);
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            }

            case CardActionType.ForceOpponentReroll:
            {
                int oppPickedDie = -1;
                if (owner.isAI)
                {
                    oppPickedDie = AIManager.Instance.ChooseDieTarget(target, effect.actionType);
                    yield return new WaitForSeconds(1.0f);
                }
                else
                {
                    Debug.Log("[CardResolver] BREAK: Select an opponent's die to force reroll.");
                    BattleManager.Instance?.ShowNotification("Select an opponent's die to reroll.", 2.5f);
                    bool oppSelected = false;
                    DiceManager.Instance.RequestDieSelection(target, (idx, p) => { oppPickedDie = idx; oppSelected = true; });
                    yield return new WaitUntil(() => oppSelected);
                }
                
                DiceManager.Instance.ForceRerollDie(oppPickedDie);
                yield return new WaitForSeconds(0.5f);
                break;
            }

            case CardActionType.AddRollAttempt:
                int extraRolls = Mathf.Max(1, Mathf.CeilToInt(finalValue));
                Debug.Log($"[CardResolver] Added {extraRolls} roll attempt(s)!");
                UI_CombatLog.Instance?.LogMessage($"Added {extraRolls} roll attempt(s)!", Color.black);
                
                if (DiceManager.Instance != null)
                {
                    DiceManager.Instance.AddRollAttempts(extraRolls);
                }
                
                BattleManager.Instance.hasActivatedAbilityThisPhase = false;
                break;
                
            // === COMBAT ACTIONS (Resolution Phase) ===
            case CardActionType.PreventDamage:
                if (BattleManager.Instance != null)
                {
                    BattleManager.Instance.AddTurnPrevention(target, finalValue);
                }
                break;
                
            case CardActionType.AddAttackModifier:
                if (BattleManager.Instance != null) BattleManager.Instance.AddTurnAttackModifier(finalValue);
                break;
                
            case CardActionType.AddCounterDamage:
                if (BattleManager.Instance != null) BattleManager.Instance.AddTurnCounterDamage(finalValue);
                break;
                
            case CardActionType.SwapRequiredSymbols:
                Debug.Log("[CardResolver] Swapping Spider for Web in conditions!");
                UI_CombatLog.Instance?.LogMessage("Spider Sense will succeed on Web instead of Spider!", Color.black);
                if (BattleManager.Instance != null) BattleManager.Instance.isSpiderSenseSwapped = true;
                break;
                
            case CardActionType.MakeAttackUndefendable:
                if (BattleManager.Instance != null)
                {
                    BattleManager.Instance.turnAttackUndefendable = true;
                    UI_CombatLog.Instance?.LogMessage($"{owner.characterData.heroName}'s next attack is Undefendable!", Color.black);
                }
                break;

            default:
                Debug.LogWarning($"[CardResolver] Action Type {effect.actionType} unknown!");
                break;
        }
    }

    // Overload for processing an AbilityOutcome (internally used in SecondaryRolls)
    private IEnumerator ResolveOutcomeRoutine(AbilityOutcome effect, PlayerController owner, float scalingMultiplier = 1f)
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
            UI_CombatLog.Instance?.LogMessage($"Scaling effect applied! Total: {finalValue}", Color.black);
        }

        switch (effect.type)
        {
            case AbilityOutcomeType.GainCP:
                target.ChangeCP(Mathf.CeilToInt(finalValue));
                break;
            case AbilityOutcomeType.Healing:
                target.ChangeHealth(Mathf.CeilToInt(finalValue));
                break;
            case AbilityOutcomeType.Damage:
                target.ChangeHealth(-Mathf.CeilToInt(finalValue));
                break;
            case AbilityOutcomeType.AttackModifier:
                if (BattleManager.Instance != null) BattleManager.Instance.AddTurnAttackModifier(finalValue);
                break;
            case AbilityOutcomeType.Prevent:
                if (BattleManager.Instance != null) BattleManager.Instance.AddTurnPrevention(target, finalValue);
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