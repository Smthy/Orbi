using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChanger : MonoBehaviour
{
    private const float Seconds = 60f;  

    void Awake()
    {
        StartCoroutine("stageChanger");
    }

    IEnumerator stageChanger()
    {
        yield return new WaitForSeconds(Seconds);       

        SceneManager.LoadScene("Level 9 - EndGame");


    }
}
