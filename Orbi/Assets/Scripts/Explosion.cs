using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Explosion : MonoBehaviour
{
    public GameObject remains;

    //sets the player to a different entity this one is of multiple cubes that break up.

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "DeathSpot")
        {
            Instantiate(remains, transform.position, transform.rotation * Quaternion.Euler(0f, 0f, 45f));
            
            Destroy(gameObject);
        }
    }

   


}
