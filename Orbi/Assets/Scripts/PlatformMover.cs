using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour {

    //platform Mover

    public GameObject top, bottom, platform;
    private float mSpeed;

    private bool Reach;

    void Start()
    {
        Reach = true;
        mSpeed = 12.5f;
        

    }

    //uses a bool to see if is at a certain point, if it is then move it to the top if not move it down

    void Update()
    {
        if (Reach == true)
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, top.transform.position, mSpeed * Time.deltaTime);
            
            if (platform.transform.position == top.transform.position)
            {
                Reach = false;
            }
        }
        else if(Reach == false)
        {
            platform.transform.position = Vector3.MoveTowards(platform.transform.position, bottom.transform.position, mSpeed * Time.deltaTime);
            if (platform.transform.position == bottom.transform.position)
            {
                Reach = true;
            }
        }
        else
        {
            print("Error");
            return;
        }
    }
}
