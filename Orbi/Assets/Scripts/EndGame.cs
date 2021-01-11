using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    //Return to main menu

    public void Return()
    {
        SceneManager.LoadScene("Level 0 - Menu");
    }
}
