using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class UI_CardModal : MonoBehaviour
{
    public static UI_CardModal Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    
    [Header("Card Display")]
    public UI_CardController displayCard;

    [Header("Buttons")]
    public Button playButton;
    public Button sellButton;
    public Button closeButton;
    public TextMeshProUGUI playButtonText;

    private CardData currentCard;
    private PlayerController currentOwner;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
        
        if (playButton != null) playButton.onClick.AddListener(OnPlayClicked);
        if (sellButton != null) sellButton.onClick.AddListener(OnSellClicked);
        if (closeButton != null) closeButton.onClick.AddListener(Hide);

        Hide();
    }

    private void Start()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged += HandlePhaseChanged;
        }
    }

    private void OnDestroy()
    {
        if (BattleManager.Instance != null)
        {
            BattleManager.Instance.OnPhaseChanged -= HandlePhaseChanged;
        }
    }

    private void HandlePhaseChanged(TurnPhase phase)
    {
        if (modalPanel != null && modalPanel.activeSelf)
        {
            ValidateButtons();
        }
    }

    public void Show(CardData card, PlayerController owner)
    {
        if (card == null || owner == null) return;

        currentCard = card;
        currentOwner = owner;

        if (displayCard != null)
        {
            displayCard.Initialize(card, owner);
            displayCard.SetViewOnly();
        }

        ValidateButtons();

        modalPanel.SetActive(true);
        transform.SetAsLastSibling();
    }

    private void ValidateButtons()
    {
        TurnPhase phase = BattleManager.Instance.currentPhase;
        bool isMainPhase = (phase == TurnPhase.MainPhase1 || phase == TurnPhase.MainPhase2);
        bool canSell = isMainPhase && (BattleManager.Instance.activePlayer == currentOwner);
        sellButton.interactable = canSell;

        bool isCorrectPhaseForCard = false;
        switch (currentCard.playPhase)
        {
            case CardPlayPhase.MainPhase:
                isCorrectPhaseForCard = isMainPhase && (BattleManager.Instance.activePlayer == currentOwner);
                break;
            case CardPlayPhase.RollPhase:
                isCorrectPhaseForCard = (phase == TurnPhase.OffensiveRollPhase || phase == TurnPhase.DefensiveRollPhase);
                break;
            case CardPlayPhase.Instant:
                isCorrectPhaseForCard = true;
                break;
        }

        bool hasEnoughCP = currentOwner.currentCombatPoints >= currentCard.cpCost;
        
        bool hasPriority = ActionStackManager.Instance != null && ActionStackManager.Instance.playerWithPriority == currentOwner;

        // Verificam constrangerile (Conditiile) cartii
        bool conditionMet = true;
        string conditionFailReason = "";

        if (currentCard.cardEffects != null)
        {
            foreach (var effect in currentCard.cardEffects)
            {
                // Phase Conditions
                if (effect.condition == CardConditionType.OnOffensiveRoll && phase != TurnPhase.OffensiveRollPhase)
                {
                    conditionMet = false; conditionFailReason = "WRONG PHASE";
                }
                else if (effect.condition == CardConditionType.OnDefensiveRoll && phase != TurnPhase.DefensiveRollPhase)
                {
                    conditionMet = false; conditionFailReason = "WRONG PHASE";
                }
                
                if (effect.condition == CardConditionType.WhenAttacked)
                {
                    if (BattleManager.Instance.currentPhase != TurnPhase.DefensiveRollPhase || 
                        BattleManager.Instance.opponentPlayer != currentOwner ||
                        BattleManager.Instance.committedOffense == null)
                    {
                        conditionMet = false;
                        conditionFailReason = "NOT ATTACKED";
                    }
                }
                else if (effect.condition == CardConditionType.DiscardStatus)
                {
                    StatusEffectsData reqStatus = effect.statusRequirement != null ? effect.statusRequirement : (effect.statuses?.Count > 0 ? effect.statuses[0].status : null);
                    if (reqStatus != null)
                    {
                        var existing = currentOwner.activeStatuses.FirstOrDefault(s => s.data == reqStatus);
                        int cost = effect.discardAmount > 0 ? effect.discardAmount : 1;
                        if (existing == null || existing.currentStacks < cost)
                        {
                            conditionMet = false;
                            conditionFailReason = $"NO STATUS";
                        }
                    }
                }

                // Undefendable Constraint
                if (effect.actionType == CardActionType.MakeAttackUndefendable)
                {
                    bool hasValidAttack = false;
                    if (phase == TurnPhase.OffensiveRollPhase && BattleManager.Instance.pendingOffensiveAbility != null && BattleManager.Instance.pendingOffensiveAbility.attackType != DamageType.None)
                        hasValidAttack = true;
                    else if (phase == TurnPhase.DefensiveRollPhase && BattleManager.Instance.committedOffense != null && BattleManager.Instance.committedOffense.runtimeAttackType != DamageType.None)
                        hasValidAttack = true;

                    if (!hasValidAttack)
                    {
                        conditionMet = false;
                        conditionFailReason = "NO VALID ATTACK";
                    }
                }

                // Prevent Damage Constraint
                if (effect.actionType == CardActionType.PreventDamage)
                {
                    bool hasIncomingDamage = false;
                    
                    PlayerController target = effect.targetMode == CardTargetMode.Opponent ? 
                        ((BattleManager.Instance.activePlayer == currentOwner) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer) : 
                        currentOwner;

                    if (target == BattleManager.Instance.opponentPlayer && BattleManager.Instance.committedOffense != null && BattleManager.Instance.committedOffense.runtimeAttackType != DamageType.None)
                        hasIncomingDamage = true;
                    else if (target == BattleManager.Instance.activePlayer && BattleManager.Instance.turnCounterDamage > 0)
                        hasIncomingDamage = true;

                    if (!hasIncomingDamage)
                    {
                        conditionMet = false;
                        conditionFailReason = "NO DMG INCOMING";
                    }
                }

                // Status Gain Limit Check
                if (effect.actionType == CardActionType.GainStatus && effect.statuses != null)
                {
                    foreach (var statusApp in effect.statuses)
                    {
                        StatusEffectsData statusToGain = statusApp.status;
                        if (statusToGain != null)
                        {
                            PlayerController target = effect.targetMode == CardTargetMode.Opponent ? 
                                ((BattleManager.Instance.activePlayer == currentOwner) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer) : 
                                currentOwner;

                            if (statusToGain.maxGlobalTokens > 0)
                            {
                                int p1Stacks = BattleManager.Instance.player1.activeStatuses.FirstOrDefault(s => s.data == statusToGain)?.currentStacks ?? 0;
                                int p2Stacks = BattleManager.Instance.player2.activeStatuses.FirstOrDefault(s => s.data == statusToGain)?.currentStacks ?? 0;
                                if (p1Stacks + p2Stacks >= statusToGain.maxGlobalTokens)
                                {
                                    conditionMet = false;
                                    conditionFailReason = "LIMIT REACHED";
                                }
                            }
                            
                            var existing = target.activeStatuses.FirstOrDefault(s => s.data == statusToGain);
                            if (existing != null && existing.currentStacks >= statusToGain.stackLimit)
                            {
                                conditionMet = false;
                                conditionFailReason = "LIMIT REACHED";
                            }
                        }
                    }
                }

                // Action Type Constraints (Dice Manipulation)
                bool isDiceAction = effect.actionType == CardActionType.ChangeDiceValue || 
                                    effect.actionType == CardActionType.RerollDice || 
                                    effect.actionType == CardActionType.ForceOpponentReroll || 
                                    effect.actionType == CardActionType.ChangeDiceValueIdenticalToAnother || 
                                    effect.actionType == CardActionType.ChangeDiceValueToSix || 
                                    effect.actionType == CardActionType.IncrementOrDecrement;
                                    
                if ((isDiceAction || effect.actionType == CardActionType.AddRollAttempt) && phase == TurnPhase.DefensiveRollPhase && !BattleManager.Instance.canActivateDefensiveAbility)
                {
                    conditionMet = false; conditionFailReason = "UNDEFENDABLE";
                }

                if (isDiceAction && DiceManager.Instance != null)
                {
                    PlayerController rollingPlayer = (phase == TurnPhase.DefensiveRollPhase) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer;
                    PlayerController opponent = (BattleManager.Instance.activePlayer == currentOwner) ? BattleManager.Instance.opponentPlayer : BattleManager.Instance.activePlayer;

                    if (!DiceManager.Instance.hasRolledThisPhase)
                    {
                        conditionMet = false; conditionFailReason = "NO DICE ROLLED";
                    }
                    else if (effect.targetMode == CardTargetMode.Self && rollingPlayer != currentOwner)
                    {
                        conditionMet = false; conditionFailReason = "NOT YOUR DICE";
                    }
                    else if (effect.targetMode == CardTargetMode.Opponent && rollingPlayer != opponent)
                    {
                        conditionMet = false; conditionFailReason = "NO OPPONENT DICE"; // DICE ROLLED
                    }
                }

                // Action Type Constraints (Status Manipulation)
                if (effect.actionType == CardActionType.RemoveStatus)
                {
                    int totalTokens = BattleManager.Instance.player1.activeStatuses.Count + BattleManager.Instance.player2.activeStatuses.Count;
                    if (totalTokens == 0) { conditionMet = false; conditionFailReason = "NO TOKENS"; }
                }
                else if (effect.actionType == CardActionType.TransferStatus)
                {
                    int totalTransferable = BattleManager.Instance.player1.activeStatuses.Count(s => s.data.isTransferable) + BattleManager.Instance.player2.activeStatuses.Count(s => s.data.isTransferable);
                    if (totalTransferable == 0) { conditionMet = false; conditionFailReason = "NO TOKENS"; }
                }
            }
        }

        if (!hasEnoughCP) playButtonText.text = "NO CP!";
        else if (!conditionMet) playButtonText.text = conditionFailReason;
        else playButtonText.text = "PLAY";

        playButton.interactable = isCorrectPhaseForCard && hasEnoughCP && hasPriority && conditionMet;
    }

    private void OnPlayClicked()
    {
        if (CardResolver.Instance != null)
        {
            CardResolver.Instance.PlayCard(currentCard, currentOwner);
        }
        Hide();
    }

    private void OnSellClicked()
    {
        if (CardResolver.Instance != null)
            CardResolver.Instance.SellCard(currentCard, currentOwner);
        Hide();
    }

    public void Hide()
    {
        modalPanel.SetActive(false);
    }
}