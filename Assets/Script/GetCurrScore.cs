using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCurrScore : MonoBehaviour
{

    private Text getScore;
    // Start is called before the first frame update

    public void Awake(){
        getScore = transform.Find("getScore").GetComponent<Text>();
    }
    void Start()
    {
        PlayerPrefs.SetInt("highscore", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
