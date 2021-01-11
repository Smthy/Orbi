using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Pause menu

    public static bool Paused = false;
    public GameObject PauseUI;

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Time.timeScale = 1f;
                Resume();
            }
            else
            {
                Time.timeScale = 0f;
                Pause();
            }
        }  
	}

    //sets the pause menu to off and cursor is hiden

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //sets the pause menu to on

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Level 0 - Menu");
    }

    public void QuitGame()
    {
        print("QuitGame");
        Application.Quit();
    }
}
