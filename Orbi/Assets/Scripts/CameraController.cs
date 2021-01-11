using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private float movePercentage, mSpeed;
    private bool CameraMove;
    
    //starts everything off

    void Start()
    {
        CameraMove = false;
        movePercentage = 0;
        mSpeed = 1.25f;
        player = GameObject.FindWithTag("Player");
        MoveSpeed();
    }


    //Moves the camera to the players position
	void Update ()
    {       
        if (CameraMove == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10), movePercentage);
        }    
	}

    void MoveSpeed()
    {
        movePercentage += mSpeed * Time.deltaTime;
        if(movePercentage > 1f)
        {
            movePercentage = 1f;
        }
    }
}

