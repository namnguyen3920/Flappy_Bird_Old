using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingTap : MonoBehaviour
{
    public GameObject tapped;

    public void Start(){
        tapped.SetActive(true);
        Time.timeScale = 0;
    }
    public void HideStarter(){
        if (tapped.activeSelf == true){
            tapped.SetActive(false);
            Time.timeScale = 1;
        } else {
            tapped.SetActive(true);
            Time.timeScale = 0;
        }
            
    }
}
