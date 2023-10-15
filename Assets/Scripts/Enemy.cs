using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void Update()
    {
        if (lives == 0) 
        {
            SceneManager.LoadScene(1);
        }
    }
}
