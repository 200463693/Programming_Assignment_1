using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    int playerscore = gameObject.GetComponent<PlayerScore>().score;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerscore = score + 100;
        Debug.Log(playerscore);
       
    }
}
