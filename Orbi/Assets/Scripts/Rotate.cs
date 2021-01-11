using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    //Background tile rotations

    float xSpin;
    float ySpin;
    float zSpin;
    public float speed;

    void Start()
    {
        xSpin = Random.Range(0, 360);
        ySpin = Random.Range(0, 360);
        zSpin = Random.Range(0, 360);
    }

    void Update ()
    {        
        transform.Rotate(new Vector3(xSpin, ySpin, zSpin) * speed * Time.deltaTime);
    }
}
