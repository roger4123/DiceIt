using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;

public class UI_TokensPoolModal : MonoBehaviour
{
    public static UI_TokensPoolModal Instance;

    [Header("UI References")]
    public GameObject modalPanel;
    public Transform gridContainer;
    public GameObject tokenPrefab;
    public Button closeButton;

    private PlayerController currentOwner;
    public PlayerController CurrentOwner => currentOwner;

    public bool IsSelectingToken { get; private set; }
    private Action<StatusEffectsData> pendingTokenSelectionCallback;

    private List<GameObject> spawnedTokens = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
        if (closeButton != null) closeButton.onClick.AddListener(Hide);
        Hide();
    }

    public void Show(PlayerController owner)
    {
        if (owner == null) return;

        if (currentOwner != null) currentOwner.OnStatusChanged -= RefreshPool;
        currentOwner = owner;
        currentOwner.OnStatusChanged += RefreshPool;

        RefreshPool();
        modalPanel.SetActive(true);
        transform.SetAsLastSibling(); // Forteaza Pool-ul sa se puna in fata UI-ului principal
    }

    public void Hide()
    {
        if (currentOwner != null) currentOwner.OnStatusChanged -= RefreshPool;
        currentOwner = null;
        modalPanel.SetActive(false);

        if (UI_TokenDetailModal.Instance != null)
        {
            UI_TokenDetailModal.Instance.Hide();
        }

        // cancel selection if modal is closed
        if (IsSelectingToken)
        {
            IsSelectingToken = false;
            pendingTokenSelectionCallback?.Invoke(null);
            pendingTokenSelectionCallback = null;
        }
    }

    public void RequestTokenSelection(PlayerController targetPlayer, Action<StatusEffectsData> callback)
    {
        IsSelectingToken = true;
        pendingTokenSelectionCallback = callback;
        Show(targetPlayer);
    }

    public void SelectToken(StatusEffectsData tokenData)
    {
        if (IsSelectingToken)
        {
            IsSelectingToken = false;
            var callback = pendingTokenSelectionCallback;
            pendingTokenSelectionCallback = null;
            
            Hide();
            callback?.Invoke(tokenData);
        }
    }

    private void RefreshPool()
    {
        if (currentOwner == null) return;

        foreach (var token in spawnedTokens) Destroy(token);
        spawnedTokens.Clear();

        foreach (var specificStatus in currentOwner.characterData.characterSpecificStatuses)
        {
            int stacks = currentOwner.activeStatuses.FirstOrDefault(s => s.data == specificStatus)?.currentStacks ?? 0;
            SpawnToken(specificStatus, stacks);
        }
    }

    private void SpawnToken(StatusEffectsData data, int stacks)
    {
        GameObject obj = Instantiate(tokenPrefab, gridContainer);
        UI_TokenPrefab tokenScript = obj.GetComponent<UI_TokenPrefab>();
        if (tokenScript != null) tokenScript.Setup(data, stacks);
        spawnedTokens.Add(obj);
    }
}