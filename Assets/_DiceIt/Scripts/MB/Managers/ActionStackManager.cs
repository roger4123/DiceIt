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

    // called by BattleManager at the start of interactive phases
    public void BeginInteractivePhase(PlayerController startingPlayer = null)
    {
        actionStack.Clear();
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

            if (actionStack.Count > 0)
            {
                ResolveTopAction();
            }
            else
            {
                Debug.Log("[Stack] Both players passed on an empty stack. Advancing phase.");
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