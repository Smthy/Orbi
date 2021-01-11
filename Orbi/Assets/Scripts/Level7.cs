using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7 : MonoBehaviour
{ 

    //Hole in the world system

    void OnTriggerEnter(Collider portal)
    {
        if (portal.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
}
