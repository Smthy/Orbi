using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour {

    //changes volume of the music.

    public Slider Volumes;
    public AudioSource Music;
    
    void Update()
    {
        Music.volume = Volumes.value;
    }

    


}
