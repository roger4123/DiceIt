using UnityEngine;
using System.Collections.Generic;

public enum CardPlayPhase { MainPhase, RollPhase, Instant }
public enum CardType { Action, Upgrade }
public enum CardTargetMode 
{ 
    None,
    Self,               
    Opponent,           
    ChosenPlayer,
    Everyone,
    SourceToDestination
}

public enum CardActionType 
{
    // resources
    Damage, Heal, GainCP, DrawCard, GainStatus,
    
    // statuses
    RemoveStatus, TransferStatus, DiscardToGain,     
    
    // dice
    ChangeDiceValue,
    RerollDice,     
    AddRollAttempt, 
    ForceOpponentReroll,
    ChangeDiceValueIdenticalToAnother,
    ChangeDiceValueToSix,
    IncrementOrDecrement,
    
    // attack/defence
    PreventDamage, AttackModifier,

    // special
    SwapRequiredSymbols
}

public enum CardConditionType
{
    None,
    OnOffensiveRoll,
    OnDefensiveRoll,
    WhenAttacked
}

[System.Serializable]
public class CardOutcome
{
    public string label;
    public CardTargetMode targetMode;
    public CardActionType actionType;
    public float value;
    

    [Header("Status & Cost Logic")]
    public List<StatusApplication> statuses;
    public StatusEffectsData statusRequirement;
    public int discardAmount = 1;
    public int extraCPCost;  

    [Header("Special Targeting")]
    // used for targetMode == SourceToDestination
    public CardTargetMode secondaryTargetMode; 

    [Header("Conditionality")]
    public CardConditionType condition = CardConditionType.None;
    public bool isScaling;
}


[CreateAssetMenu(fileName = "NewCard", menuName = "DiceIt/Card")]
public class CardData : ScriptableObject
{
    [Header("Visuals & Identity")]
    public string cardName;
    [TextArea] public string description;
    public Sprite cardArtwork;

    [Header("Logic")]
    public CardType cardType;
    public CardPlayPhase playPhase;
    public int cpCost;

    [Header("Effects")]
    public List<CardOutcome> cardEffects;

    [Header("Secondary Rolls")]
    public List<SecondaryRoll> cardRolls;

    [Header("Upgrade Logic (Optional)")]
    public BaseAbilityData abilityToUpgrade;
    public BaseAbilityData upgradedAbilityVersion;
}
