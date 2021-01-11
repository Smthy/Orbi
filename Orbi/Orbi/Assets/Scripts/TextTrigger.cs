using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour {

    public GameObject doorway;
    

    void OnTriggerEnter(Collider door)
    {
        if(door.CompareTag("Player"))
        {
            doorway.SetActive(false);
        }
    }
	
	
	
}
