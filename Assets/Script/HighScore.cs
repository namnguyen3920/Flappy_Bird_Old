using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class static HighScore
{

    private Text highScore;

    public static int GetHighScore (){
        return PlayerPrefs.GetInt("highscore");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
