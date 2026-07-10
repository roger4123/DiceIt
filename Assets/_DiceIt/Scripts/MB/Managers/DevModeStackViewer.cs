using UnityEngine;
using UnityEngine.InputSystem;

public class DevModeStackViewer : MonoBehaviour
{
    private bool showMenu = false;
    private Rect windowRect = new Rect(330, 20, 300, 380); 

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.backslashKey.wasPressedThisFrame)
        {
            showMenu = !showMenu;
        }
    }

    void OnGUI()
    {
        if (!showMenu) return;
        windowRect = GUILayout.Window(998, windowRect, DrawStackWindow, "Action Stack Viewer");
    }

    void DrawStackWindow(int windowID)
    {
        if (ActionStackManager.Instance == null)
        {
            GUILayout.Label("Waiting for ActionStackManager...");
            GUI.DragWindow();
            return;
        }

        var stackArray = ActionStackManager.Instance.GetCurrentStack();
        
        GUILayout.Label($"--- STACK CONTENTS (Count: {stackArray.Length}) ---");
        GUILayout.Space(10);

        if (stackArray.Length == 0)
        {
            GUILayout.Label("Stack is completely empty.");
        }
        else
        {
            //index 0 =  stack top
            for (int i = 0; i < stackArray.Length; i++)
            {
                var action = stackArray[i];
                string position = (i == 0) ? "[TOP] " : $" [{i}]  ";
                GUILayout.Label($"{position} {action.SourcePlayer.characterData.heroName}: {action.ActionName}");
            }
        }

        GUILayout.Space(20);
        GUILayout.Label("--- PRIORITY ---");
        string prioPlayer = ActionStackManager.Instance.playerWithPriority != null 
            ? ActionStackManager.Instance.playerWithPriority.characterData.heroName 
            : "None";
        GUILayout.Label($"Current Turn To Act: {prioPlayer}");

        GUI.DragWindow();
    }
}