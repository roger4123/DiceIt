using UnityEngine;

[CreateAssetMenu(fileName = "NewSymbol", menuName = "DiceIt/Dice Symbol")]
public class DiceSymbol : ScriptableObject
{
    public string symbolName;
    public Sprite symbolIcon;
    public Color symbolColor = Color.black;

}