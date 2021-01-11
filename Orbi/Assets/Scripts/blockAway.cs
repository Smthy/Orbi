using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockAway : MonoBehaviour {

    public GameObject block1, block2, block3, audio1, audio2;


    //Settings the audio and Coroutine
	void Start ()
    {        
        audio1.SetActive(true);
        StartCoroutine("blockDisappear");
	}	

    //Using a IEnumerator to allow audio to play one after the other.

    IEnumerator blockDisappear()
    {
        yield return new WaitForSeconds(15f);

        audio1.SetActive(false);
        audio2.SetActive(true);

        yield return new WaitForSeconds(6f);

        block1.SetActive(false);
        block2.SetActive(false);
        block3.SetActive(false);
    }

}
