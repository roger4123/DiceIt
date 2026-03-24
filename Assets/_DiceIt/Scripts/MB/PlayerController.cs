using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using TMPro;

// instanta activa a unui player in timpul jocului
// gestionare HP, CP si Status Effects
public class PlayerController : MonoBehaviour   
{
    [Header("UI Reference")]
    public TextMeshProUGUI healthBarandCPText;
    public List<UI_AbilitySlots> abilitySlots = new List<UI_AbilitySlots>();

    [Header("Data Reference")]
    public CharacterData characterData;
    public bool isAI = false;

    [Header("Runtime Stats")]
    public int currentHealth;
    public int currentCombatPoints;

    [Header("Card Management")]
    public List<CardData> drawDeck = new List<CardData>();
    public List<CardData> hand = new List<CardData>();
    public List<CardData> discardPile = new List<CardData>();

    [System.Serializable]
    public class ActiveStatus
    {
        public StatusEffectsData data;
        public int currentStacks;

        public ActiveStatus(StatusEffectsData data, int amount)
        {
            this.data = data;
            currentStacks = amount;
        }
    }
    public List<ActiveStatus> activeStatuses = new List<ActiveStatus>();

    public void InitializePlayer()
    {
        if (characterData == null) return;

        currentHealth = characterData.maxHealth;
        currentCombatPoints = characterData.startingCombatPoints;
        activeStatuses.Clear();

        InitializeDeck();
        
        Debug.Log($"{characterData.heroName} initialized with {currentHealth} HP and {drawDeck.Count} cards.");

        UpdateHpCpUI();
        PopulateAbilityBoard();
    }
    
    private void Start()
    {
        InitializePlayer();
    }

    #region Deck & Hand Logic

    public void ShuffleDeck()
    {
        for (int i = 0; i < drawDeck.Count; i++)
        {
            CardData temp = drawDeck[i];
            int randomIndex = Random.Range(i, drawDeck.Count);
            drawDeck[i] = drawDeck[randomIndex];
            drawDeck[randomIndex] = temp;
        }
    }

    public void DrawCards(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            if (drawDeck.Count == 0)
            {
                if (discardPile.Count > 0)
                {
                    drawDeck.AddRange(discardPile);
                    discardPile.Clear();
                    ShuffleDeck();
                    Debug.Log("Discard pile reshuffled into draw deck.");
                }
                else
                {
                    Debug.LogWarning("No more cards to draw!");
                    break;
                }
            }

            CardData card = drawDeck[0];
            drawDeck.RemoveAt(0);
            hand.Add(card);
        }
    }

    private void InitializeDeck()
    {
        drawDeck.Clear();
        hand.Clear();
        discardPile.Clear();

        if (characterData.deckRecipe != null)
        {
            foreach (var card in characterData.deckRecipe.cards)
            {
                drawDeck.Add(card);
            }
            ShuffleDeck();
        }

        DrawCards(characterData.startingCards);
    }

    public void DiscardCard(CardData card)
    {
        if (hand.Contains(card))
        {
            hand.Remove(card);
            discardPile.Add(card);
        }
    }

    public bool CanAffordToPlayCard(CardData card)
    {
        return currentCombatPoints >= card.cpCost;
    }

    #endregion

    #region Health & Resources
    
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, characterData.maxHealth);
        
        if (currentHealth <= 0)
        {
            Debug.Log($"{characterData.heroName} was defeated!");
            // de pus triggerul pentru evenimentul Defeat/Loss in TurnController
        }

        UpdateHpCpUI();
    }

    public void ChangeCP(int amount)
    {
        currentCombatPoints = Mathf.Clamp(currentCombatPoints + amount, 0, characterData.maxCombatPoints);
        UpdateHpCpUI();
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
    
    #region UI Logic

    public void UpdateHpCpUI()
    {
        if (healthBarandCPText != null)
        {
            healthBarandCPText.text = $"{characterData.heroName}: {currentHealth}/{characterData.maxHealth} HP | {currentCombatPoints}/{characterData.maxCombatPoints} CP";
        } 
    }

    public void PopulateAbilityBoard()
    {
        if (characterData == null || abilitySlots.Count == 0) return;

        bool hasPassive = characterData.passive != null && !string.IsNullOrEmpty(characterData.passive.abilityName);

        foreach (var slot in abilitySlots)
        {
            BaseAbilityData dataToAssign = null;
            int idx = slot.slotIndex;

            switch(idx)
            {
                case int i when i >= 0 && i <= 3:
                    if (i < characterData.offensiveAbilities.Count)
                    {
                        dataToAssign = characterData.offensiveAbilities[i];
                    }
                    break;

                case 4:
                    int offIndexForA6 = hasPassive ? 4 : 5;
                    if (characterData.offensiveAbilities.Count > offIndexForA6)
                        dataToAssign = characterData.offensiveAbilities[offIndexForA6];
                    break;

                case 10:
                    // Passive Ability has priority
                    if (hasPassive)
                    {
                        dataToAssign = characterData.passive;
                    }
                    else if (characterData.offensiveAbilities.Count > 4)
                    {
                        dataToAssign = characterData.offensiveAbilities[4];
                    }
                    break;

                case 20:
                    if (characterData.defensiveAbilities.Count > 0)
                    {
                        dataToAssign = characterData.defensiveAbilities[0];
                    }
                    break;

                case 21:
                    if (characterData.defensiveAbilities.Count > 1)
                    {
                        dataToAssign = characterData.defensiveAbilities[1];
                    }
                    else
                    {
                        int offIndexforA7 = hasPassive ? 5 : 6;
                        if (characterData.offensiveAbilities.Count > offIndexforA7)
                        {
                            dataToAssign = characterData.offensiveAbilities[offIndexforA7];
                        }
                    }
                    break;

                case 50:
                    dataToAssign = characterData.ultimateAbility;
                    break;
            }

            if (dataToAssign != null)
            {
                slot.gameObject.SetActive(true);
                slot.Setup(dataToAssign, this);
            }
            else
            {
                slot.gameObject.SetActive(false);
            }            
        }
    }
    #endregion
}