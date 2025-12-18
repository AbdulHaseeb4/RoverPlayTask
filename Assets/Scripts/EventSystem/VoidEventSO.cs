using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Game Events/Void Event")]
public class VoidEventSO : ScriptableObject
{
    private UnityEvent unityEvent = new UnityEvent();

    public void Raise()
    {
        unityEvent.Invoke();
    }

    public void Register(UnityAction listener)
    {
        unityEvent.AddListener(listener);
    }

    public void Unregister(UnityAction listener)
    {
        unityEvent.RemoveListener(listener);
    }
}
