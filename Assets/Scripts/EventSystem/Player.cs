using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Player ko damage hua");
            GameEvents.PlayerDamaged?.Invoke();
        }
    }
}
