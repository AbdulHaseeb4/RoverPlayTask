using System;
using UnityEngine;

public class TestingEvents : MonoBehaviour
{
    public event EventHandler OnSpacePressed;

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Space pressed!
            OnSpacePressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
