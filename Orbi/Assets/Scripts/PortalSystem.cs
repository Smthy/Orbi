using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalSystem : MonoBehaviour
{
    //uses it as the scene changer
    public Animator playerPortal;

    
    void OnTriggerEnter(Collider portal)
    {
        if(portal.CompareTag("Player"))
        {
            StartCoroutine(PlayerPortalSystem());           
        }
    }


    //animation for protals
    IEnumerator PlayerPortalSystem()
    {
        playerPortal.SetTrigger("Portal");
        playerPortal.Play("PlayerPortal");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
