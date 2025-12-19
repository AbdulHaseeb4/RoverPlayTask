using System.Collections;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    public float wait = 2.0f;

    private void Start()
    {
        StartCoroutine("WaitRoutine");
        StartCoroutine("StopWaitRoutine");
    }

    IEnumerator WaitRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            Debug.Log("<color=red>Wait for 2 seconds</color>");
        }
    }

    IEnumerator StopWaitRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        StopCoroutine("WaitRoutine");
        Debug.Log("<color=yellow>WaitRoutine stopped</color>");
    }
}
