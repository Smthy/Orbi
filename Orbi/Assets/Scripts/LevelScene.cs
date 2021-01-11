using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScene : MonoBehaviour
{

    //public static int is what is used to set the level menu activation
    public static int LevelNumber;
    int buildIndex;

    //gets the current scene

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        buildIndex = currentScene.buildIndex; 
    }

    //Keeps updating to check if they are on the right level

    void Update()
    {
        if(buildIndex == 1)
        {
            LevelNumber = 1;
        }
        else if (buildIndex == 2)
        {
            LevelNumber = 2;
        }
        else if(buildIndex == 3)
        {
            LevelNumber = 3;
        }
        else if (buildIndex == 4)
        {
            LevelNumber = 4;
        }
        else if (buildIndex == 5)
        {
            LevelNumber = 5;
        }
        else if (buildIndex == 6)
        {
            LevelNumber = 6;
        }
        else if (buildIndex == 7)
        {
            LevelNumber = 7;
        }
        else if (buildIndex == 8)
        {
            LevelNumber = 8;
        }
    }

}
