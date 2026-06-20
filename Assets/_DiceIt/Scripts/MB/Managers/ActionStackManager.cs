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
        // treat the pass button as a "cancel" button for when selecting dice and you've changed your mind 
        if (isIntentionalPass && DiceManager.Instance != null && DiceManager.Instance.CurrentInteractionState == DiceInteractionState.SelectingDice)
        {
            Debug.Log("[Stack] Intercepted PassPriority to cancel die selection.");
            DiceManager.Instance.CancelDieSelection();
            return;
        }

        if (isIntentionalPass)
        {
            consecutivePasses++;
            Debug.Log($"[Stack] {playerWithPriority.characterData.heroName} passed priority.");
            
            AIDataLogger.Instance?.LogPlayerAction(playerWithPriority, "PassPriority", "None");
        }

        if (consecutivePasses >= 2)
        {
            // Both players passed. Time to act.
            if (actionStack.Count > 0)
            {
                // If there's something on the stack, resolve the top action.
                Debug.Log("[Stack] Both players passed. Resolving top action on the stack.");
                ResolveTopAction();
            }
            else
            {
                // If the stack is empty, it's safe to advance the phase.
                Debug.Log("[Stack] Both players passed and stack is empty. Advancing phase.");
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

        ResetPriorityPasses();
        GivePriorityTo(BattleManager.Instance.activePlayer);
    }

    private void GivePriorityTo(PlayerController player)
    {
        playerWithPriority = player;
        Debug.Log($"[Stack] Priority goes to {playerWithPriority.characterData.heroName}.");
        OnPriorityChanged?.Invoke(playerWithPriority);
    }
}