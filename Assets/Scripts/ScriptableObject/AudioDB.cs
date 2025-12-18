using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorial.DB
{
    [Serializable]
    public enum AudioName
    {
        TAP,
        KILL,
        TURN,
        MOVE,
        GAMEOVER
    }

    [CreateAssetMenu(menuName ="Tutorial/ScriptableObject/AudioDB")]
    public class AudioDB : ScriptableObject
    {
        [Serializable]
        public struct Audio
        {
            public AudioName name;
            public AudioClip audioClip;
            public float volume;
        }

        [SerializeField] private List<Audio> audios;

        public Audio GetAudio(AudioName audioName) => audios.Find(x => x.name == audioName);
    }
}
