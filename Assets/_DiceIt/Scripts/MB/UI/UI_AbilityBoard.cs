using UnityEngine;
using System.Collections.Generic;

public class UI_AbilityBoard : MonoBehaviour
{
    [Header("Target")]
    public PlayerController targetPlayer;

    [Header("UI Elements")]
    public List<UI_AbilitySlot> abilitySlots = new List<UI_AbilitySlot>();

    private void OnEnable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization += PopulateBoard;
            targetPlayer.OnAbilitiesChanged += RefreshBoard;
        }
    }

    private void OnDisable()
    {
        if (targetPlayer != null)
        {
            targetPlayer.OnCharacterInitialization -= PopulateBoard;
            targetPlayer.OnAbilitiesChanged -= RefreshBoard;
        }
    }

    private void Start()
    {
        if (DiceManager.Instance != null) DiceManager.Instance.OnDiceStateChanged += OnDiceChanged;
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += OnPhaseChanged;
            BattleManager.Instance.OnDefenseSelected += UpdateHighlights;
        }
        UpdateHighlights();
    }

    private void OnDestroy()
    {
        if (DiceManager.Instance != null) DiceManager.Instance.OnDiceStateChanged -= OnDiceChanged;
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= OnPhaseChanged;
            BattleManager.Instance.OnDefenseSelected -= UpdateHighlights;
        }
    }

    private void OnDiceChanged(List<DiceManager.DieState> dice, int rollsLeft) { UpdateHighlights(); }
    
    private void OnPhaseChanged(TurnPhase phase) { UpdateHighlights(); }

    private void RefreshBoard()
    {
        PopulateBoard(targetPlayer.characterData, targetPlayer);
        UpdateHighlights();
    }

    private void PopulateBoard(CharacterData characterData, PlayerController owner)
    {
        if (characterData == null || abilitySlots.Count == 0 || owner == null) return;

        bool hasPassive = owner.activePassive != null && !string.IsNullOrEmpty(owner.activePassive.abilityName);

        foreach (var slot in abilitySlots)
        {
            BaseAbilityData dataToAssign = null;
            int idx = slot.slotIndex;

            switch(idx)
            {
                case int i when i >= 0 && i <= 3:
                    if (i < owner.activeOffensiveAbilities.Count)
                    {
                        dataToAssign = owner.activeOffensiveAbilities[i];
                    }
                    break;

                case 4:
                    int offIndexForA6 = hasPassive ? 4 : 5;
                    if (owner.activeOffensiveAbilities.Count > offIndexForA6)
                        dataToAssign = owner.activeOffensiveAbilities[offIndexForA6];
                    break;

                case 10:
                    // Passive Ability has priority
                    if (hasPassive)
                    {
                        dataToAssign = owner.activePassive;
                    }
                    else if (owner.activeOffensiveAbilities.Count > 4)
                    {
                        dataToAssign = owner.activeOffensiveAbilities[4];
                    }
                    break;

                case 20:
                    if (owner.activeDefensiveAbilities.Count > 0)
                    {
                        dataToAssign = owner.activeDefensiveAbilities[0];
                    }
                    break;

                case 21:
                    if (owner.activeDefensiveAbilities.Count > 1)
                    {
                        dataToAssign = owner.activeDefensiveAbilities[1];
                    }
                    else
                    {
                        int offIndexforA7 = hasPassive ? 5 : 6;
                        if (owner.activeOffensiveAbilities.Count > offIndexforA7)
                        {
                            dataToAssign = owner.activeOffensiveAbilities[offIndexforA7];
                        }
                    }
                    break;

                case 50:
                    dataToAssign = owner.activeUltimate;
                    break;
            }

            if (dataToAssign != null)
            {
                slot.gameObject.SetActive(true);
                slot.Setup(dataToAssign, owner);
            }
            else
            {
                slot.gameObject.SetActive(false);
            }            
        }
    }

    private void UpdateHighlights()
    {
        if (targetPlayer == null || BattleManager.Instance == null) return;

        var currentPhase = BattleManager.Instance.currentPhase;
        bool isRollingPlayer = (currentPhase == TurnPhase.DefensiveRollPhase) 
                             ? targetPlayer == BattleManager.Instance.opponentPlayer 
                             : targetPlayer == BattleManager.Instance.activePlayer;

        List<int> currentDice = DiceManager.Instance != null ? DiceManager.Instance.GetCurrentDiceValues() : new List<int>();

        foreach (var slot in abilitySlots)
        {
            if (!slot.gameObject.activeSelf || slot.assignedAbility == null) continue;

            if (slot.assignedAbility is OffensiveAbilityData offAb)
            {
                // Offensive: matched the required dice?
                if (currentPhase == TurnPhase.OffensiveRollPhase && isRollingPlayer)
                {
                    var validTiers = AbilityMatcher.GetValidActivations(offAb, currentDice, targetPlayer.characterData.diceKey);
                    if (validTiers.Count > 0) slot.SetHighlight(new Color(0.4f, 1f, 0.4f));
                    else slot.ResetHighlight();
                }
                else slot.ResetHighlight();
            }
            else if (slot.assignedAbility is DefensiveAbilityData defAb)
            {
                // Defensive: Normal damage type?
                if (currentPhase == TurnPhase.DefensiveRollPhase && isRollingPlayer && BattleManager.Instance.canActivateDefensiveAbility)
                {
                    if (BattleManager.Instance.pendingDefenseSelection == null)
                    {
                        slot.SetHighlight(Color.yellow);
                    }
                    else if (BattleManager.Instance.pendingDefenseSelection == defAb)
                    {
                        if (DiceManager.Instance != null && DiceManager.Instance.hasRolledThisPhase)
                        {
                            bool anyConditionMet = false;
                            if (AbilityResolver.Instance != null)
                            {
                                foreach (var outcome in defAb.primaryDefensiveOutcomes)
                                {
                                    if (AbilityResolver.Instance.IsConditionMet(outcome, currentDice, targetPlayer.characterData.diceKey, out _))
                                    {
                                        anyConditionMet = true;
                                        break;
                                    }
                                }
                            }
                            slot.SetHighlight(anyConditionMet ? new Color(0.4f, 1f, 0.4f) : Color.yellow);
                        }
                        else
                        {
                            slot.SetHighlight(Color.yellow);
                        }
                    }
                    else
                    {
                        slot.ResetHighlight();
                    }
                }
                else slot.ResetHighlight();
            }
        }
    }
}