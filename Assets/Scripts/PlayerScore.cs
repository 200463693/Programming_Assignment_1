using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int playerscore = 0;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerscore = playerscore + 100;
    }


    void Update()
    {
        Debug.Log(playerscore);
    }
}
