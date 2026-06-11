using UnityEngine;
using System.Collections.Generic;

public enum StatusType { Positive, Negative }
public enum StatusTarget { Self, Opponent }
public enum StatusTrigger
{ 
    None,            // Passive
    OnTurnStart,     // Upkeep Phase (SOT)
    OnTurnEnd,       // EOT
    OnAttackDealt,
    OnAttackReceived,
    OnManualSpend,
    OnInflicted,
    OnRemoved,
    ReachingStackLimit,
}

public enum StatusOutcomeType     // What does the SE do when activated
{
    None,
    Damage,
    Healing,
    GainCP,
    DrawCard,
    Prevent,
    TakeBonusORP,
    ChangeAttackType,
}

[System.Serializable]
public class StatusOutcome
{
    public StatusTrigger activationTrigger;
    public StatusTarget target;
    public StatusOutcomeType type;
    public float value;

    [Header("Condition (Optional)")]
    // ex: Do X if rolled 6
    public int requiredRollValue; 
    public bool useCondition;
}

[CreateAssetMenu(fileName = "NewStatusEffect", menuName = "DiceIt/Status Effect")]
public class StatusEffectsData : ScriptableObject
{
    [Header("Information")]
    public string effectName;
    public StatusType type;
    [TextArea] public string description;
    public Sprite icon;

    [Header("Visuals")]
    public Color backgroundColor = Color.white;
    public Color iconColor = Color.white;

    [Header("Permissions (Token Pool Logic)")]
    public bool canBeRemovedByOwner = true;
    public bool canBeRemovedByOpponent = true;
    public bool isTransferable = true;
    public bool isUnique;

    [Header("Lifecycle & Rules")]
    public int stackLimit = 1;
    public int maxGlobalTokens;
    public bool isPersistent; // persists in between turns if not spent
    public bool isSpendable; // != passive effect

    [Header("Logic & Triggers")]
    public List<StatusOutcome> primaryStatusEffectOutcomes; // effects list
}