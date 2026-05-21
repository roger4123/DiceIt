using System;
using System.Collections.Generic;
using UnityEngine;

public class ActionStackManager : MonoBehaviour
{
    public static ActionStackManager Instance;

    private Stack<IStackableAction> actionStack = new Stack<IStackableAction>();
    
    [Header("State")]
    public PlayerController playerWithPriority;
    private int consecutivePasses = 0;

    public event Action<IStackableAction> OnActionAddedToStack;
    public event Action<IStackableAction> OnActionResolved;
    public event Action<PlayerController> OnPriorityChanged;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public IStackableAction[] GetCurrentStack()
    {
        return actionStack.ToArray();
    }

    // called by BattleManager at the start of interactive phases
    public void BeginInteractivePhase(PlayerController startingPlayer = null)
    {
        consecutivePasses = 0;
        PlayerController firstActor = startingPlayer != null ? startingPlayer : BattleManager.Instance.activePlayer;
        GivePriorityTo(firstActor);
    }

    public void AddActionToStack(IStackableAction action)
    {
        actionStack.Push(action);
        consecutivePasses = 0; // when an action has happened
        
        // INSTANT EFFECTS RESOLUTION
        if (action is ActivateAbilityAction abilityAction)
        {
            var bm = BattleManager.Instance;
            if (abilityAction.ability is OffensiveAbilityData offAb && abilityAction.activationIndex != -1)
            {
                var activation = offAb.activations[abilityAction.activationIndex];
                var primaryDice = DiceManager.Instance != null ? DiceManager.Instance.GetCurrentDiceValues() : new List<int>();
                
                foreach (var outcome in activation.primaryOutcomes)
                {
                    if (bm.IsConditionMet(outcome, primaryDice, abilityAction.SourcePlayer.characterData.diceKey, out float primaryScalingMult))
                    {
                        bm.ApplyInstantEffects(outcome, abilityAction.SourcePlayer, bm.opponentPlayer, primaryScalingMult);
                    }
                }
                
                // secondary outcomes
                if (activation.secondaryRolls != null && activation.secondaryRolls.Count > 0)
                {
                    var secRoll = activation.secondaryRolls[0];
                    foreach (var outcome in secRoll.outcomes)
                    {
                        if (bm.IsConditionMet(outcome, abilityAction.secondaryRollResults, abilityAction.SourcePlayer.characterData.diceKey, out float scalingMult))
                        {
                            bm.ApplyInstantEffects(outcome, abilityAction.SourcePlayer, bm.opponentPlayer, scalingMult);
                        }
                    }
                }
            }
        }

        Debug.Log($"[Stack] {action.SourcePlayer.characterData.heroName} added {action.ActionName} to the stack.");
        OnActionAddedToStack?.Invoke(action);

        PassPriority(false); 
    }

    public void ReassertPriority()
    {
        OnPriorityChanged?.Invoke(playerWithPriority);
    }

    public void ResetPriorityPasses()
    {
        consecutivePasses = 0;
    }

    public void PassPriority(bool isIntentionalPass = true)
    {
        if (isIntentionalPass)
        {
            consecutivePasses++;
            Debug.Log($"[Stack] {playerWithPriority.characterData.heroName} passed priority.");
        }

        if (consecutivePasses >= 2)
        {
            consecutivePasses = 0;

            // if top action is a non-damage-ability action, resolve instantly
            if (actionStack.Count > 0 && !(actionStack.Peek() is ActivateAbilityAction))
            {
                Debug.Log("[Stack] Both players passed. Resolving Instant Action.");
                ResolveTopAction();
            }
            else
            {
                Debug.Log("[Stack] Both players passed. Advancing phase.");
                BattleManager.Instance.AdvancePhase();
            }
        }
        else
        {
            
            PlayerController nextPlayer = (playerWithPriority == BattleManager.Instance.player1) 
                                          ? BattleManager.Instance.player2 
                                          : BattleManager.Instance.player1;
            GivePriorityTo(nextPlayer);
        }
    }

    public void ResolveAllPendingActions()
    {
        while (actionStack.Count > 0)
        {
            ResolveTopAction();
        }
    }

    private void ResolveTopAction()
    {
        if (actionStack.Count == 0) return;

        IStackableAction topAction = actionStack.Pop();
        Debug.Log($"[Stack] Resolving action: {topAction.ActionName}");
        
        topAction.Execute();
        OnActionResolved?.Invoke(topAction);

        GivePriorityTo(BattleManager.Instance.activePlayer);
    }

    private void GivePriorityTo(PlayerController player)
    {
        playerWithPriority = player;
        Debug.Log($"[Stack] Priority goes to {playerWithPriority.characterData.heroName}.");
        OnPriorityChanged?.Invoke(playerWithPriority);
    }
}