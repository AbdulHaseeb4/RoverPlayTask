using System;
using UnityEngine;

public class Subscriber : MonoBehaviour
{
    private void Start()
    {
        TestingEvents testingEvents = GetComponent<TestingEvents>();
        testingEvents.OnSpacePressed += TestingEvents_OnSpacePressed;
    }

    private void TestingEvents_OnSpacePressed(object sender, EventArgs e)
    {
        Debug.Log("Space!");
    }
}
