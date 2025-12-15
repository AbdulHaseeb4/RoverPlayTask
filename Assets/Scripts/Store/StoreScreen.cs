using UnityEngine;

public class StoreScreen : MonoBehaviour
{
    [Header("Two Packs")]
    public CanvasGroup packA;
    public CanvasGroup packB;

    [Header("Gold Amount Per Pack")]
    public int packAGold = 100;
    public int packBGold = 250;

    [Header("Fake Remote Flag")]
    public bool packsActive = false;

    private void Start()
    {
        ApplyState();
    }

    private void OnValidate()
    {
        if (!Application.isPlaying) return;
        ApplyState();
    }

    public void SetPacksActive(bool active)
    {
        packsActive = active;
        ApplyState();
    }

    private void ApplyState()
    {
        if (packsActive)
        {
            Show(packA);
            Show(packB);
        }
        else
        {
            Hide(packA);
            Hide(packB);
        }
    }

    public void BuyPackA()
    {
        if (!packsActive) return;

        GoldManager.Instance.AddGold(packAGold);
        Debug.Log($"Bought Pack A → +{packAGold} Gold");
    }

    public void BuyPackB()
    {
        if (!packsActive) return;

        GoldManager.Instance.AddGold(packBGold);
        Debug.Log($"Bought Pack B → +{packBGold} Gold");
    }

    private void Show(CanvasGroup g)
    {
        g.alpha = 1;
        g.interactable = true;
        g.blocksRaycasts = true;
    }

    private void Hide(CanvasGroup g)
    {
        g.alpha = 0;
        g.interactable = false;
        g.blocksRaycasts = false;
    }
}
