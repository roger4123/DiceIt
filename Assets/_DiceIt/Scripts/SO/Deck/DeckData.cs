using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewDeck", menuName = "DiceIt/Deck")]
public class DeckData : ScriptableObject
{
    [Header("Deck Configuration")]
    public string deckName;
    
    [Tooltip("Must have 32 cards.")]
    public List<CardData> cards = new List<CardData>(32);

    public bool IsValidDeck()
    {
        return cards.Count == 32;
    }

    /// helper for Inspector
    public void GetDeckStats(out int main, out int roll, out int instant)
    {
        main = 0; roll = 0; instant = 0;
        foreach(var card in cards)
        {
            if (card == null) continue;
            if (card.playPhase == CardPlayPhase.MainPhase) main++;
            else if (card.playPhase == CardPlayPhase.RollPhase) roll++;
            else if (card.playPhase == CardPlayPhase.Instant) instant++;
        }
    }

    [ContextMenu("Print Deck Stats in Console")]
    public void PrintStatsToConsole()
    {
        GetDeckStats(out int main, out int roll, out int instant);
        Debug.Log($"Deck: {deckName} | Main: {main} | Roll: {roll} | Instant: {instant}");
    }
}