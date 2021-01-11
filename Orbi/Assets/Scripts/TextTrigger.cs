using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour {

    //shows text to tell players about different objects in the game

    bool active;
    public GameObject doorway, text;
   

    void Start()
    {
        text.SetActive(false);
        active = true;
    }

    void OnTriggerEnter(Collider door)
    {
        if(door.CompareTag("Player") && active == true)
        {
            text.SetActive(true);
            doorway.SetActive(false);
            active = false;
            StartCoroutine("TextDisappear");
        }
    }	
	

    IEnumerator TextDisappear()
    {
        yield return new WaitForSeconds(3f);
        text.SetActive(false);
    }
}
