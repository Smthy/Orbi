using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //basic menu script

    public GameObject mainMenu, settings;

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1 - Movement");
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
    
    public void Return()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }

    public void LevelMenu()
    {
        SceneManager.LoadScene("Level 10 - Level Select");
    }
}
