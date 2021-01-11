using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenuActivator : MonoBehaviour
{
    public Button Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8;

    void Update()
    {
        Levels();
    }

    //Once a player gone on that level
    //Uses a singleton to allow the int to be set from each level

    void Levels()
    {
        if(LevelScene.LevelNumber == 1)
        {
            Level1.interactable = true;
            Level2.interactable = false;
            Level3.interactable = false;
            Level4.interactable = false;
            Level5.interactable = false;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 2)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = false;
            Level4.interactable = false;
            Level5.interactable = false;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 3)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = false;
            Level5.interactable = false;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 4)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = false;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 5)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 6)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = false;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 7)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = false;
        }
        else if (LevelScene.LevelNumber == 8)
        {
            Level1.interactable = true;
            Level2.interactable = true;
            Level3.interactable = true;
            Level4.interactable = true;
            Level5.interactable = true;
            Level6.interactable = true;
            Level7.interactable = true;
            Level8.interactable = true;
        }
        else
        {
            Level1.interactable = false;
            Level2.interactable = false;
            Level3.interactable = false;
            Level4.interactable = false;
            Level5.interactable = false;
            Level6.interactable = false;
            Level7.interactable = false;
            Level8.interactable = false;
        }
    }

    public void level1()
    {
        SceneManager.LoadScene("Level 1 - Movement");
    }

    public void level2()
    {
        SceneManager.LoadScene("Level 2 - Jumping");
    }

    public void level3()
    {
        SceneManager.LoadScene("Level 3 - Long Jump");
    }

    public void level4()
    {
        SceneManager.LoadScene("Level 4 - Death Chance");
    }

    public void level5()
    {
        SceneManager.LoadScene("Level 5 - climbing");
    }

    public void level6()
    {
        SceneManager.LoadScene("Level 6 - Blockage");
    }

    public void level7()
    {
        SceneManager.LoadScene("Level 7 - Hole in the World");
    }

    public void level8()
    {
        SceneManager.LoadScene("Level 7.5 - Choice");
    }

    public void menu()
    {
        SceneManager.LoadScene("Level 0 - Menu");
    }

}
