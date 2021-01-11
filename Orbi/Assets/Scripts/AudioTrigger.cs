using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioTrigger : MonoBehaviour {

    public AudioSource audioSource;
    public GameObject Trigger;    
    private bool enter; 
      
    void Start ()
    {
        enter = true;        
    }   

    //Using a public static to change the volume of audio triggers
    void Update()
    {
        audioSource.volume = SpeechChanger.speechChanger.VolumeLevel;       
    }

    //Makes the triggers a 1 time use only
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (enter == true)
            {
                audioSource.Play();
                enter = false;
            }
            else
            {
                print("false");
            }

        }
    }
}
