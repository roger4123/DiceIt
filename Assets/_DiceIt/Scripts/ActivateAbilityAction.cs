using UnityEngine;

public class ActivateAbilityAction : IStackableAction
{
    private PlayerController source;
    private BaseAbilityData ability;

    public string ActionName => ability != null ? ability.abilityName : "Unknown Ability";
    public PlayerController SourcePlayer => source;

    public ActivateAbilityAction(PlayerController source, BaseAbilityData ability)
    {
        this.source = source;
        this.ability = ability;
    }

    public void Execute()
    {
        Debug.Log($"[Action Stack] Executing {ability.abilityName} by {source.characterData.heroName}");
        
        if (ability is OffensiveAbilityData offAbility)
        {
            // save the ability as "Pending Attack" in BattleManager (for later in Resolution Phase)
            Debug.Log("[Action Stack] Offensive outcome registered and waiting for Defense Phase.");
        }
        else if (ability is DefensiveAbilityData defAbility)
        {
            Debug.Log("[Action Stack] Defensive outcome registered.");
        }
    }
}