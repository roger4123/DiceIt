using UnityEngine;

[CreateAssetMenu(fileName = "NewDiceKey", menuName = "DiceIt/Dice Key")]
public class DiceKeyData : ScriptableObject
{
    [Header("Visuals")]
    public Color dieColor = Color.white;
    public Color symbolColor = Color.black;

    [Header("Faces (1 to 6)")]
    public DiceSymbol[] faces = new DiceSymbol[6];

    public DiceSymbol GetSymbolForValue(int value)
    {
        int index = Mathf.Clamp(value - 1, 0, 5);
        return faces[index];
    }
}