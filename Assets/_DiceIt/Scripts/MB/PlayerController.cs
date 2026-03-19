using UnityEngine;
using System.Collections.Generic;
using System.Linq;

// instanta activa a unui player in timpul jocului
// gestionare HP, CP si Status Effects
public class PlayerController : MonoBehaviour   
{
    [Header("Data Reference")]
    public CharacterData characterData;
    public bool isAI = false;

    [Header("Runtime Stats")]
    public int currentHealth;
    public int currentCombatPoints;

    [System.Serializable]
    public class ActiveStatus
    {
        public StatusEffectsData data;
        public int currentStacks;

        public ActiveStatus(StatusEffectsData data, int amount)
        {
            this.data = data;
            this.currentStacks = amount;
        }
    }
    public List<ActiveStatus> activeStatuses = new List<ActiveStatus>();

    public void InitializePlayer()
    {
        if (characterData == null) return;

        currentHealth = characterData.maxHealth;
        currentCombatPoints = characterData.startingCombatPoints;
        activeStatuses.Clear();
        
        Debug.Log($"{characterData.heroName} initialized with {currentHealth} HP.");
    }
    
    private void Start()
    {
        InitializePlayer();
    }

    #region Health & Resources
    
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, characterData.maxHealth);
        
        if (currentHealth <= 0)
        {
            Debug.Log($"{characterData.heroName} was defeated!");
            // de pus triggerul pentru evenimentul Defeat/Loss in TurnController
        }
    }

    public void ChangeCP(int amount)
    {
        currentCombatPoints = Mathf.Clamp(currentCombatPoints + amount, 0, characterData.maxCombatPoints);
    }

    #endregion

    #region Status Management

    public void AddStatus(StatusEffectsData status, int amount)
    {
        // Căutăm dacă avem deja acest status
        var existing = activeStatuses.FirstOrDefault(s => s.data == status);

        if (existing != null)
        {
            existing.currentStacks = Mathf.Min(existing.currentStacks + amount, status.stackLimit);
        }
        else
        {
            activeStatuses.Add(new ActiveStatus(status, amount));
        }
        
        Debug.Log($"{characterData.heroName} gained Status Effect: {status.effectName} (+{amount})");
    }

    public void RemoveStatus(StatusEffectsData status, int amount = 1)
    {
        var existing = activeStatuses.FirstOrDefault(s => s.data == status);
        if (existing != null)
        {
            existing.currentStacks -= amount;
            if (existing.currentStacks <= 0)
            {
                activeStatuses.Remove(existing);
            }
        }
    }

    #endregion

    #region Outcome Processing

    private void ProcessNumericalOutcome(AbilityOutcome outcome)
    {
        switch (outcome.type)
        {
            case OutcomeType.Damage:
                ChangeHealth(-(int)outcome.value);
                break;

            case OutcomeType.Healing:
                ChangeHealth((int)outcome.value);
                break;

            case OutcomeType.GainCP:
                ChangeCP((int)outcome.value);
                break;

            case OutcomeType.Prevent:
                // Logica de prevenție va fi gestionată de BattleManager în faza de Defensive Roll,
                // modificând incomingDamage înainte să apeleze ChangeHealth.
                break;

            case OutcomeType.None:
                // nu face nimic numeric, probabil doar statusuri for now
                break;
                
            default:
                Debug.LogWarning($"OutcomeType {outcome.type} not implemented yet.");
                break;
        }
    }

    public void ApplyOutcome(AbilityOutcome outcome)
    {
        ProcessNumericalOutcome(outcome);

        foreach (var statusApp in outcome.statuses)
        {
            AddStatus(statusApp.status, statusApp.amount);
        }
    }

    #endregion
}
