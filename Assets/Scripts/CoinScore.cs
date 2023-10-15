using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CoinScore : MonoBehaviour
{
    public static CoinScore Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        //displays starting score
        scoreText.text = score.ToString();
    }
    void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void UpdateScoreText(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
