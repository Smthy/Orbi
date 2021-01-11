using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalChoice : MonoBehaviour
{
    //lets the player choose the protal
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PortalKill")
        {
            SceneManager.LoadScene("Level 8 - Cutscene");
        }

        if (other.gameObject.name == "PortalLive")
        {
            SceneManager.LoadScene("Level 9.5 - EndGame (Alive)");
        }
    }  
}
