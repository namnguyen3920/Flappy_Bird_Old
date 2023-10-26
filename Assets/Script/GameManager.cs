using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    public void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(0);
    }
}
