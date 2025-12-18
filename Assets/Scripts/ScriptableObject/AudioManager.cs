using UnityEngine;

namespace Tutorial.DB
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioDB audioDB;
        [SerializeField] private AudioSource audioSource;

        public void PlayMove() => Play(AudioName.MOVE);
        public void PlayTap() => Play(AudioName.TAP);
        public void PlayKill() => Play(AudioName.KILL);
        public void PlayTurn() => Play(AudioName.TURN);
        public void PlayGameOver() => Play(AudioName.GAMEOVER);

        private void Play(AudioName audioName)
        {
            var audio = audioDB.GetAudio(audioName);
            audioSource.clip = audio.audioClip;
            audioSource.volume = audio.volume;
            audioSource.Play();
        }
    }
}
