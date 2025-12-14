using UnityEngine;
using System.Collections.Generic;

public class UIManager2 : MonoBehaviour
{
    public static UIManager2 Instance;

    [Header("Add ALL panels here (first = default)")]
    [SerializeField] private List<CanvasGroup> panels;

    private void Awake()
    {
        Instance = this;

        // hide all
        foreach (var p in panels)
            Hide(p);

        // default screen = first panel
        if (panels.Count > 0)
            Show(panels[0]);
    }

    // MAIN FUNCTION FOR BUTTONS
    public void ShowPanel(string panelName)
    {
        foreach (var p in panels)
        {
            if (p.name == panelName)
                Show(p);
            else
                Hide(p);
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
