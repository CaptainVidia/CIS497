/*
 * George Tang
 * Assignment 7 - Challenge 4
 * sets conditions for player to win and loss, instructions are shown
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConditionManagerX : MonoBehaviour
{
    public Text conditionText;
    public static bool gameOver, win, gameStart;
    public static float enemyScored;

    void Start()
    {
        gameOver = false;
        win = false;
        gameStart = false;
        enemyScored = -1;
        StartCoroutine(Conditions());
    }

    IEnumerator Conditions()
    {
       conditionText.alignment = TextAnchor.MiddleCenter;
       conditionText.fontSize = 30;
       conditionText.text = "Knock Enemies into enemy goal to WIN in 10 waves! You Lose if all enemies go into goal" +
            "\nPress the SPACEBAR to begin.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

       conditionText.alignment = TextAnchor.UpperLeft;
       conditionText.fontSize = 20;

        gameStart = true;

        yield break;
    }

    void Update()
    {
        if (gameOver)
        {
            if (win)
            {
               conditionText.alignment = TextAnchor.MiddleCenter;
               conditionText.fontSize = 30;
               conditionText.text = "Congratulations!\nYou Win!\n(Press R to play again)";
            }
            else
            {
               conditionText.alignment = TextAnchor.MiddleCenter;
               conditionText.fontSize = 30;
               conditionText.text = "You Lost! Better Luck Next Time!\n(Press R to try again)";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
               conditionText.alignment = TextAnchor.UpperLeft;
               conditionText.fontSize = 14;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}