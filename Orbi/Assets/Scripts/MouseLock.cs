using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseLock : MonoBehaviour
{
    //Locks the mouse and hides it.
    int build;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //only allowed on certain scenes

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        build = currentScene.buildIndex;

        if(build == 0 || build == 10 || build == 11 || build == 12)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }    
}
