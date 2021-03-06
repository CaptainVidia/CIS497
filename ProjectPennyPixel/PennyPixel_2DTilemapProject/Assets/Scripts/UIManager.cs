﻿//Author: George Tang
//Assignment: Prototype 3
//Description: Trigger Zones. if trigger zones are hit one point is added to the player's score

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        // win conditoon 3 or more
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\n Press R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose!\n Press R to Try Again!";
            }

        }
        // outsude of the if statement so player can restart the game at any time
        // instead of a must trigger win or lose
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
