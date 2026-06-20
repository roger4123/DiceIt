using UnityEngine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// "observer"
public class AIDataLogger : MonoBehaviour
{
    public static AIDataLogger Instance;

    [Header("Logging Settings")]
    public bool isLoggingEnabled = true;
    public string csvFileName = "DemonstrationData.csv";

    private string filePath;
    
    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        string directoryPath = Path.Combine(Application.dataPath, "../ML_Data");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        filePath = Path.Combine(directoryPath, csvFileName);
        InitializeCSV();
    }

    private void InitializeCSV()
    {
        if (!File.Exists(filePath))
        {
            string header = "Timestamp,ActionType,ActionDetail,TurnPhase,IsMyTurn,PlayerID,PlayerHP,PlayerCP,OpponentHP,OpponentCP,PlayerPosTokens,PlayerNegTokens,OppPosTokens,OppNegTokens,BoardDice,RollsLeft,HandSize,OpponentHandSize,CardsInHand\n";
            File.WriteAllText(filePath, header);
        }
    }

    public void LogPlayerAction(PlayerController player, string actionType, string actionDetail)
    {
        if (!isLoggingEnabled || player == null || player.isAI) return;

        var bm = BattleManager.Instance;
        if (bm == null) return;

        PlayerController opponent = (bm.player1 == player) ? bm.player2 : bm.player1;

        string phase = bm.currentPhase.ToString();
        int isMyTurn = (bm.activePlayer == player) ? 1 : 0;
        int playerID = (player == bm.player1) ? 1 : 2;
        int php = player.currentHealth;
        int pcp = player.currentCombatPoints;
        int ohp = opponent.currentHealth;
        int ocp = opponent.currentCombatPoints;

        // board state (stacks counts instead of types count)
        int pPosT = player.activeStatuses.Where(s => s.data.type == StatusType.Positive).Sum(s => s.currentStacks);
        int pNegT = player.activeStatuses.Where(s => s.data.type == StatusType.Negative).Sum(s => s.currentStacks);
        int oPosT = opponent.activeStatuses.Where(s => s.data.type == StatusType.Positive).Sum(s => s.currentStacks);
        int oNegT = opponent.activeStatuses.Where(s => s.data.type == StatusType.Negative).Sum(s => s.currentStacks);

        // dice
        List<int> dice = DiceManager.Instance != null ? DiceManager.Instance.GetCurrentDiceValues() : new List<int>{0,0,0,0,0};
        while (dice.Count < 5) dice.Add(0); 
        string boardDiceStr = string.Join("|", dice);

        int rollsLeft = DiceManager.Instance != null ? DiceManager.Instance.rollsLeft : 0;
        int handSize = player.hand.Count;
        int oppHandSize = opponent.hand != null ? opponent.hand.Count : 0;

        // '|' as separator
        string cardsInHandStr = handSize > 0 ? string.Join("|", player.hand.Select(c => c.cardName.Replace(",", ";"))) : "None";

        string timestamp = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

        string safeActionDetail = actionDetail.Replace(",", ";");
        string csvLine = $"{timestamp},{actionType},{safeActionDetail},{phase},{isMyTurn},{playerID},{php},{pcp},{ohp},{ocp},{pPosT},{pNegT},{oPosT},{oNegT},{boardDiceStr},{rollsLeft},{handSize},{oppHandSize},{cardsInHandStr}\n";

        try
        {
            File.AppendAllText(filePath, csvLine);
        }
        catch (Exception e)
        {
            Debug.LogError($"[AIDataLogger] Error at CSV writing: {e.Message}");
        }
    }
}