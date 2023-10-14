using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int lives = 3;
    void Start()
    {
        Debug.Log(lives);
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lives = lives - 1;
        Debug.Log(lives);
    }
}
