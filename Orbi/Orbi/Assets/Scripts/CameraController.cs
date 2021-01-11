using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private float movePercentage, mSpeed;
    
	
    void Start()
    {
        movePercentage = 0;
        mSpeed = 1.25f;
        player = GameObject.FindWithTag("Player");
        MoveSpeed();
    }

	void Update ()
    {
        //Vector3.Lerp(Vector3 a, Vector3 b, float t);
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - 10), movePercentage);
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z  - 10);
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

