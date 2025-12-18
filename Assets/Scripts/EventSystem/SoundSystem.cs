using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    private void OnEnable()
    {
        GameEvents.PlayerDamaged += PlaySound;
    }

    private void OnDisable()
    {
        GameEvents.PlayerDamaged -= PlaySound;
    }

    void PlaySound()
    {
        Debug.Log("Damage sound chala");
    }
}
