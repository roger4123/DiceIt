using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class AbilityMatcher
{
    #region Straights Logic

    private static bool HasStraightOfLength(List<int> values, int targetLength)
    {
        // removing duplicates and sorting
        var distinctVals = values.Distinct().OrderBy(v => v).ToList();
        if (distinctVals.Count < targetLength) return false;

        int consecutiveCount = 1;

        // list traversal
        for (int i = 1; i < distinctVals.Count; i++)
        {
            if (distinctVals[i] == distinctVals[i - 1] + 1)
            {
                consecutiveCount++;
                if (consecutiveCount >= targetLength)
                {
                    return true;
                }
            }
            else
            {
                consecutiveCount = 1;
            }
        }

        return false;
    }

    private static bool HasSmallStraight(List<int> values)
    {
        return HasStraightOfLength(values, 4);
    }

    private static bool HasLargeStraight(List<int> values)
    {
        return HasStraightOfLength(values, 5);
    }

    #endregion

    #region Specific Symbols Logic

    private static bool HasSpecificSymbols(List<SymbolRequirement> requirements, List<int> rolledValues, DiceKeyData diceKey)
    {
        // counting how many symbols of each type were rolled
        Dictionary<DiceSymbol, int> rolledSymbolsCount = new Dictionary<DiceSymbol, int>();
        
        foreach (int val in rolledValues)
        {
            DiceSymbol symbol = diceKey.GetSymbolForValue(val);
            if (symbol != null)
            {
                if (rolledSymbolsCount.ContainsKey(symbol))
                    rolledSymbolsCount[symbol]++;
                else
                    rolledSymbolsCount[symbol] = 1;
            }
        }

        // check if the dictionary covers the requirements
        foreach (var req in requirements)
        {
            if (!rolledSymbolsCount.ContainsKey(req.symbol) || rolledSymbolsCount[req.symbol] < req.count)
                return false;
        }

        return true;
    }

    #endregion

     private static bool IsActivationMet(OffensiveAbilityData.AttackActivation activation, List<int> rolledValues, DiceKeyData diceKey)
    {
        switch (activation.type)
        {
            case RequirementType.SmallStraight:
                return HasSmallStraight(rolledValues);
            
            case RequirementType.LargeStraight:
                return HasLargeStraight(rolledValues);
            
            case RequirementType.SpecificSymbols:
                return HasSpecificSymbols(activation.symbolsNeeded, rolledValues, diceKey);
            
            default:
                return false;
        }
    }

    public static List<int> GetValidActivations(OffensiveAbilityData ability, List<int> rolledValues, DiceKeyData diceKey)
    {
        List<int> validTiers = new List<int>();

        if (ability == null || ability.activations == null || rolledValues == null || diceKey == null)
            return validTiers;

        for (int i = 0; i < ability.activations.Count; i++)
        {
            if (IsActivationMet(ability.activations[i], rolledValues, diceKey))
            {
                validTiers.Add(i);
            }
        }

        return validTiers;
    }
}