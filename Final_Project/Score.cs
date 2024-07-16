using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text highScoreText;
    int currentScore;
    int highScore;
    private void Start()
    {
    highScore = PlayerPrefs.GetInt("highscore",0);
    highScoreText.text = highScore.ToString();
    }
    private void Update()
    {
        currentScore = Mathf.FloorToInt(player.position.z);
        scoreText.text = currentScore.ToString();
        if(currentScore > highScore)
        {
        highScore = currentScore;
        highScoreText.text = highScore.ToString();
        PlayerPrefs.SetInt("highscore", currentScore);
        }
    }
}

