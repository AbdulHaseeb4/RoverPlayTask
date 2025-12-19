using Tutorial.SingletonTest;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTest : MonoBehaviour
{
    public void LoadMain()
    {
        SceneManager.LoadScene("Singleton");
        SingletonTest.Instance.PlayAudio();
    }

    public void LoadTest()
    {
        SceneManager.LoadScene("SingletonTestScene");
        SingletonTest.Instance.PlayAudio();
    }
}
