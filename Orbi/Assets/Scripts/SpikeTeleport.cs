using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTeleport : MonoBehaviour
{

    //resets players and planks if they hit the trigger

    public GameObject player, spawnpoint, plankRes, ground;
    

    //sets the positions

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            print("Dead");

            player.transform.position = new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z);
        }

        if(other.gameObject == ground)
        {
            print("Fallen");

            ground.transform.position = new Vector3(plankRes.transform.position.x, plankRes.transform.position.y, plankRes.transform.position.z);

        }

    }
}
