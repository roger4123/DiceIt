using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using System.Collections;

public class UI_CombatLog : MonoBehaviour
{
    public static UI_CombatLog Instance;

    [Header("UI References")]
    public Transform contentContainer;
    public GameObject textPrefab;
    public int maxMessages = 50;

    [Header("Scroll & Expand Settings")]
    public ScrollRect scrollRect;
    public RectTransform logPanelRect; 
    public float collapsedHeight = 80f;
    public float expandedHeight = 700f;

    private bool isExpanded = false;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        SetHeight(collapsedHeight);
    }

    public void LogMessage(string message, Color color)
    {
        if (contentContainer == null || textPrefab == null) return;

        string phaseName = BattleManager.Instance != null ? FormatPhase(BattleManager.Instance.currentPhase.ToString()) : "System";
        
        GameObject newLog = Instantiate(textPrefab, contentContainer);
        TextMeshProUGUI txt = newLog.GetComponent<TextMeshProUGUI>();
        
        if (txt != null)
        {
            txt.text = $"<b>[{phaseName}]</b> {message}";
            txt.color = color;
        }

        if (contentContainer.childCount > maxMessages)
        {
            Destroy(contentContainer.GetChild(0).gameObject);
        }

        StartCoroutine(ScrollToBottom());
    }

    private string FormatPhase(string phase)
    {
        return Regex.Replace(phase, "([a-z])([A-Z0-9])", "$1 $2");
    }

    private IEnumerator ScrollToBottom()
    {
        yield return new WaitForEndOfFrame();
        if (scrollRect != null)
        {
            scrollRect.verticalNormalizedPosition = 0f;
        }
    }

    public void ToggleExpand()
    {
        isExpanded = !isExpanded;
        Debug.Log($"[UI_CombatLog] ToggleExpand clicked! Setting expand state to: {isExpanded}");
        SetHeight(isExpanded ? expandedHeight : collapsedHeight);
        
        StartCoroutine(ScrollToBottom());
    }

    private void SetHeight(float height)
    {
        if (logPanelRect != null)
        {
            // SetSizeWithCurrentAnchors este varianta ideală și curată pentru redimensionare
            logPanelRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }
}
