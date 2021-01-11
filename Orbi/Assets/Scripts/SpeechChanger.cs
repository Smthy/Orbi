using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechChanger : MonoBehaviour
{
    //changes the volume of the narration

    public float VolumeLevel;
    public Slider Volumes;
    
    public static SpeechChanger speechChanger;

    void Awake()
    {
        speechChanger = this;       
    }

    void Start()
    {
        Volumes.value = 1f;
    }

    void Update()
    {
        VolumeLevel = Volumes.value;
    }
}
