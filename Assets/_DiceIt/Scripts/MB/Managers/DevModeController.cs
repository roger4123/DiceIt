using UnityEngine;
using UnityEngine.InputSystem;

public class DevModeController : MonoBehaviour
{
    private bool showMenu = false;
    private bool targetPlayer1 = true;
    private Rect windowRect = new Rect(20, 20, 300, 380);

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.backquoteKey.wasPressedThisFrame)
        {
            showMenu = !showMenu;
        }
    }

    void OnGUI()
    {
        if (!showMenu) return;

        windowRect = GUILayout.Window(999, windowRect, DrawDevWindow, "Dev Mode (Press ` to hide)");
    }

    void DrawDevWindow(int windowID)
    {
        if (BattleManager.Instance == null)
        {
            GUILayout.Label("Waiting for BattleManager...");
            GUI.DragWindow();
            return;
        }

        PlayerController p1 = BattleManager.Instance.player1;
        PlayerController p2 = BattleManager.Instance.player2;

        if (p1 == null || p2 == null)
        {
            GUILayout.Label("Waiting for players to initialize...");
            GUI.DragWindow();
            return;
        }

        GUILayout.Label("--- Target Player ---");
        GUILayout.BeginHorizontal();
        if (GUILayout.Toggle(targetPlayer1, p1.characterData.heroName, "Button")) targetPlayer1 = true;
        if (GUILayout.Toggle(!targetPlayer1, p2.characterData.heroName, "Button")) targetPlayer1 = false;
        GUILayout.EndHorizontal();

        PlayerController target = targetPlayer1 ? p1 : p2;

        GUILayout.Space(10);

        GUILayout.Label("--- Player Actions ---");
        if (GUILayout.Button("Draw 1 Card")) target.DrawCards(1);
        if (GUILayout.Button("Gain 1 CP")) target.ChangeCP(1);

        GUILayout.Label("Take Damage:");
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("-1 HP")) target.ChangeHealth(-1);
        if (GUILayout.Button("-5 HP")) target.ChangeHealth(-5);
        if (GUILayout.Button("-10 HP")) target.ChangeHealth(-10);
        GUILayout.EndHorizontal();

        GUILayout.Space(10);

        GUILayout.Label("--- Game State Actions ---");
        if (GUILayout.Button("Add 1 Roll Attempt"))
        {
            if (DiceManager.Instance != null)
            {
                DiceManager.Instance.AddRollAttempts(1);
                Debug.Log($"[DevMode] Added 1 roll attempt. Current: {DiceManager.Instance.rollsLeft}");
            }
        }

        if (GUILayout.Button("Skip Current Phase")) BattleManager.Instance.AdvancePhase();
        if (GUILayout.Button("Skip Whole Turn")) BattleManager.Instance.EndTurn();

        GUI.DragWindow();
    }
}