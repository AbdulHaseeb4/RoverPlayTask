using UnityEngine;

public class HealthUI : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.PlayerDamaged += OnPlayerDamaged;
    }

    private void OnDisable()
    {
        GameEvents.PlayerDamaged -= OnPlayerDamaged;
    }

    void OnPlayerDamaged()
    {
        Debug.Log("Health kam hui");
    }
}
