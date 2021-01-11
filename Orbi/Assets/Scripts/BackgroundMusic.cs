using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

    private static BackgroundMusic music = null;          //sets it as a singleton so it can be changed on scenes.
    public static BackgroundMusic Music
    {
        get { return music; }
    }

    void Awake()
    {
        if (music != null && music != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else                                          //doesn't destory the item the music is on when it loads the game
        {
            music = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }    
}
