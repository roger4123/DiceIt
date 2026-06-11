using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ActivateAbilityAction : IStackableAction
{
    public PlayerController SourcePlayer { get; }
    public BaseAbilityData ability { get; }
    public int activationIndex { get; }
    public List<int> secondaryRollResults { get; }
    public DamageType runtimeAttackType; // temporary overrwrite (for Webbed)

    public string ActionName => ability != null ? ability.abilityName : "Unknown Ability";

    public ActivateAbilityAction(PlayerController source, BaseAbilityData ability, int activationIndex = -1)
    {
        this.SourcePlayer = source;
        this.ability = ability;
        this.activationIndex = activationIndex;
        this.secondaryRollResults = new List<int>();

        if (ability is OffensiveAbilityData offAb) runtimeAttackType = offAb.attackType;
    }

    public ActivateAbilityAction(PlayerController source, BaseAbilityData ability, int activationIndex, List<int> secondaryRollResults)
    {
        this.SourcePlayer = source;
        this.ability = ability;
        this.activationIndex = activationIndex;
        this.secondaryRollResults = secondaryRollResults ?? new List<int>();

        if (ability is OffensiveAbilityData offAb) runtimeAttackType = offAb.attackType;
    }

    public void Execute()
    {
        Debug.Log($"[Combat Resolution] Executing {ability.abilityName} by {SourcePlayer.characterData.heroName}");

        if (AbilityResolver.Instance != null)
        {
            AbilityResolver.Instance.ResolveAbility(this);
        }
        else
        {
            Debug.LogError("[Action Stack] AbilityResolver is missing!");
        }
    }
}