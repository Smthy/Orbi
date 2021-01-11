using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicChanger : MonoBehaviour
{

    //uses to set the music level

    public float VolumeLevel;
    public Slider Volumes;

    public static MusicChanger musicChanger;

    void Awake()
    {
        musicChanger = this;
    }

    void Start()
    {
        Volumes.value = 0.25f;
    }

    void Update()
    {
        VolumeLevel = Volumes.value;
    }
}
