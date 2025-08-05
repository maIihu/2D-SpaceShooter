using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int playerScore;

    private void Start()
    {
        playerScore = 0;
        SetText();
    }

    private void OnEnable()
    {
        Enemy.OnEnemyDestroy += UpdateScore;
    }

    private void OnDisable()
    {
        Enemy.OnEnemyDestroy -=  UpdateScore;
    }


    private void UpdateScore()
    {
        playerScore++;
        SetText();
    }

    private void SetText()
    {
        scoreText.text = "Score: " + playerScore;
    }
        
}
