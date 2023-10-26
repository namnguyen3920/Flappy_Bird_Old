using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{

    public float maxTime = 1f;
    public float timer = 0f;
    public GameObject pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 7);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
