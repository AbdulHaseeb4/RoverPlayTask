using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [Header("All Screens")]
    public List<CanvasGroup> screens;

    private Stack<CanvasGroup> screenStack = new Stack<CanvasGroup>();
    private CanvasGroup currentScreen;

    private float fadeDuration = 0.25f;

    void Start()
    {
        OpenScreen(screens[0]);
    }

    public void OpenScreen(CanvasGroup newScreen)
    {
        if (currentScreen != null)
            HideScreen(currentScreen, false);

        screenStack.Push(newScreen);
        ShowScreen(newScreen);
    }

    public void Back()
    {
        if (screenStack.Count <= 1) return;

        CanvasGroup closingScreen = screenStack.Pop();
        HideScreen(closingScreen, true);

        CanvasGroup previous = screenStack.Peek();
        ShowScreen(previous);
    }

    private void ShowScreen(CanvasGroup screen)
    {
        currentScreen = screen;

        screen.alpha = 0;
        screen.interactable = true;
        screen.blocksRaycasts = true;

        screen.DOFade(1, fadeDuration).SetEase(Ease.OutSine);
    }

    private void HideScreen(CanvasGroup screen, bool disableTouch)
    {
        screen.DOFade(0, fadeDuration).SetEase(Ease.OutSine)
            .OnComplete(() =>
            {
                if (disableTouch)
                {
                    screen.interactable = false;
                    screen.blocksRaycasts = false;
                }
            });
    }
}
