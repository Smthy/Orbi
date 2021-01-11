using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SansDoor : MonoBehaviour
{

    //MEME

    public AudioSource audioSource;
    public GameObject Trigger, Door, Wall;
    public GameObject SansEye;
    private bool enter;



    void Start()
    {
        enter = true;
        
        audioSource = gameObject.GetComponent<AudioSource>();

        StartCoroutine("SansEyeFlash");
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(enter == true)
            {
                Door.SetActive(false);
                Wall.SetActive(false);
                
                audioSource.Play();
            }
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (enter == true)
            {
                Door.SetActive(true);
                Wall.SetActive(true);
                
                audioSource.Pause();
            }
        }
    }

    IEnumerator SansEyeFlash()
    {
        SansEye.SetActive(true);

        yield return new WaitForSeconds(0.3f);

        SansEye.SetActive(false);

        yield return new WaitForSeconds(0.3f);

        StartCoroutine("SansEyeFlash");
    }
}
