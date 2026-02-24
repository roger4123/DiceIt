using UnityEngine;
using System.Collections.Generic;

// Definim tipurile de statusuri pentru a le putea colora diferit în UI mai târziu
public enum StatusType { Positive, Negative }
public enum StatusTarget { Self, Opponent }
public enum StatusTrigger   // When to execute the SE logic.
{ 
    None,            // Passive
    OnTurnStart,     // Upkeep Phase (SOT)
    OnTurnEnd,       // EOT
    OnAttackDealt,
    OnAttackReceived,
    OnManualSpend,
    OnInflicted,
    OnRemoved
}

public enum OutcomeType     // What does the SE do when activated
{
    Damage,
    Healing,
    GainCP,
    DrawCard,
    AttackModifier,
    Prevent,
    TakeBonusORP,
    ChangeAttackType,   // Webbed/Invisibility
    RemoveStatus,       // Cleanse/Disruption
    StealStatus,        // Trickster
    DisableAbility,     // Spellbound
    ModifyRollAttempts, // Influence/Acuity
    TransformStatus,    // Time Bomb
    SwapDie             // Reality Warp
}

[System.Serializable]
public class StatusOutcome
{
    public StatusTrigger activationTrigger;
    public StatusTarget target;
    public OutcomeType type;
    public float value;

    [Header("Condition (Optional)")]
    // ex: Do X if rolled 6
    public int requiredRollValue; 
    public bool useCondition;
}

[CreateAssetMenu(fileName = "NewStatusEffect", menuName = "DiceIt/Status Effect")]
public class StatusEffectData : ScriptableObject
{
    [Header("Information")]
    public string effectName;
    public StatusType type;
    [TextArea] public string description;
    public Sprite icon;

    [Header("Permissions (Token Pool Logic)")]
    public bool canBeRemovedByOwner = true;
    public bool canBeRemovedByOpponent = true;
    public bool isTransferable = true;
    public bool isUnique;

    [Header("Lifecycle & Rules")]
    public int stackLimit = 1;
    public bool isPersistent; // persists in between turns if not spent
    public bool isSpendable; // Dacă necesită acțiune manuală pentru consum

    [Header("Logic & Triggers")]
    public List<StatusOutcome> outcomes; // effects list (CP, Cards, Damage, etc.)
}