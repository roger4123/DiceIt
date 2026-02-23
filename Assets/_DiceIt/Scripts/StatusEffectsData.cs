using UnityEngine;

// Definim tipurile de statusuri pentru a le putea colora diferit în UI mai târziu
public enum StatusType { Positive, Negative }

[CreateAssetMenu(fileName = "NewStatusEffect", menuName = "DiceIt/Status Effect")]
public class StatusEffectData : ScriptableObject
{
    [Header("Information")]
    public string effectName;
    public StatusType type;
    [TextArea] public string description;
    public Sprite icon;

    [Header("Rules")]
    public int stackLimit = 1;
    public bool isPersistent;
    public bool canBeRemovedByOpponent = true;
    public bool isUnique;
}