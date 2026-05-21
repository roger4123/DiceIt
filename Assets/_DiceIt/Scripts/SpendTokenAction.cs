using UnityEngine;

public class SpendTokenAction : IStackableAction
{
    public PlayerController SourcePlayer { get; }
    public StatusEffectsData tokenData { get; }
    public string ActionName => $"Spend {tokenData.effectName}";

    public SpendTokenAction(PlayerController source, StatusEffectsData tokenData)
    {
        this.SourcePlayer = source;
        this.tokenData = tokenData;
    }

    public void Execute()
    {
        Debug.Log($"[Action Stack] Executing {ActionName}");
        
        if (StatusResolver.Instance != null)
        {
            StatusResolver.Instance.ResolveSpend(this);
        }
        else
        {
            Debug.LogError("[Action Stack] StatusResolver is missing!");
        }
    }
}