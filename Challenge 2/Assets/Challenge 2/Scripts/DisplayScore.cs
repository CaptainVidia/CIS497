//Author: George Tang
//Assignment: Challenge 2
//Description: Score system

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DisplayScore: MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public static int health;

    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }
        else if (health <= 0)
        {
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "Congratulations, you won!\nPress R to play again.";
            }
            else
            {
                textbox.text = "You Lose!.\nPress R to try again.";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

}


