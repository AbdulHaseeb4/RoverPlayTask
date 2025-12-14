using System;
using UnityEngine;

public class UIManager1 : MonoBehaviour
{
    public static UIManager1 Instance;

    [SerializeField] private CanvasGroup mainMenu;
    [SerializeField] private CanvasGroup settings;
    [SerializeField] private CanvasGroup store;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowMainMenu()
    {
        Show(mainMenu);
        Hide(settings);
        Hide(store);
    }

    public void ShowSettings()
    {
        Show(settings);
        Hide(mainMenu);
        Hide(store);
    }

    public void ShowStore()
    {
        Show(store);
        Hide(mainMenu);
        Hide(settings);
    }

    private void Show(CanvasGroup g)
    {
        g.gameObject.SetActive(true);
        g.alpha = 1;
        g.blocksRaycasts = true;
        g.interactable = true;
    }

    private void Hide(CanvasGroup g)
    {
        g.alpha = 0;
        g.blocksRaycasts = false;
        g.interactable = false;
        g.gameObject.SetActive(false);
    }
}
