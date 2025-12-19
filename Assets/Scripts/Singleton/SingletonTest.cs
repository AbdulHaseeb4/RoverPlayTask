using UnityEngine;

namespace Tutorial.SingletonTest
{
    public sealed class SingletonTest : MonoBehaviour
    {
        public static SingletonTest Instance;
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private AudioClip audioClip;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    
        public void PlayAudio()
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
}