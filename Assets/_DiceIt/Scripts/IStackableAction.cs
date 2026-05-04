using UnityEngine;

public interface IStackableAction
{
    string ActionName { get; }
    PlayerController SourcePlayer { get; }
    void Execute();
}