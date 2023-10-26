using System.Runtime.CompilerServices;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingScore : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision){
        Score.score++;
    }
}
