using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        audioSource.volume = MusicChanger.musicChanger.VolumeLevel;
    }

}
