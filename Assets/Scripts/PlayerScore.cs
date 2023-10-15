using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    private PlayerScore playerScoreComponent;

    int playerscore = GameObject.Find("Coin").GetComponent<PlayerScore>().score;

    void Start()
    {
        playerScoreComponent = GameObject.Find("coin").GetComponent<PlayerScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       playerscore = score += 100;
       Debug.Log("The player score is" + score );
    }
}
