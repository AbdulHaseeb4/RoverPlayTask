using UnityEngine;
using System.Collections.Generic;

public class UIManager2 : MonoBehaviour
{
    public static UIManager2 Instance;

    [Header("All Panels")]
    [SerializeField] private List<CanvasGroup> panels;

    private void Awake()
    {
        Instance = this;

        foreach (var p in panels)
            Hide(p);

        if (panels.Count > 0)
            Show(panels[0]);
    }

    public void ShowPanel(CanvasGroup target)
    {
        foreach (var p in panels)
            Hide(p);

        Show(target);
    }

    public void ShowPopup(CanvasGroup popup)
    {
        foreach (var p in panels)
        {
            if (p.alpha > 0)
            {
                p.blocksRaycasts = false;
            }
        }

        Show(popup);
    }

    public void ClosePopup(CanvasGroup popup)
    {
        Hide(popup);

        foreach (var p in panels)
        {
            if (p.alpha > 0)
            {
                p.interactable = true;
                p.blocksRaycasts = true;
            }
        }
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
