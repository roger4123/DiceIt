using UnityEngine;
using System.Collections.Generic;

public enum PassiveTrigger { OnTurnStart, OnTurnEnd, OnDamageTaken, OnAttackDealt }

[CreateAssetMenu(fileName = "NewPassive", menuName = "DiceIt/Passive")]
public class PassiveData : ScriptableObject
{
    public string passiveName;
    [TextArea] public string description;

    [Header("Logic")]
    public PassiveTrigger trigger;
    public List<StatusOutcome> passiveEffects;
    public bool ignoreUltimate = true;
}