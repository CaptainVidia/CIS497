/*
 * George Tang
 * Assignment 7 - Prototype 4 
 * Displays information to user with instructions and win lose conditions
 * */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConditionManager : MonoBehaviour
{
    public Text conditionText;
    public static bool gameOver, win, gameStart;

    void Start()
    {
        gameOver = false;
        win = false;
        gameStart = false;
        StartCoroutine(Conditions());
    }

    IEnumerator Conditions()
    {
        conditionText.alignment = TextAnchor.MiddleCenter;
        conditionText.fontSize = 40;
        conditionText.text = "Survive 10 Waves by knocking enemies off platform to WIN! If you fall YOU LOSE! " +
            "\nPress the SPACEBAR to begin.";

        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }

        conditionText.alignment = TextAnchor.UpperLeft;
        conditionText.fontSize = 14;

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
                conditionText.fontSize = 40;
                conditionText.text = "Congratulations!\nYou Win!\n(Press R to play again)";
            }
            else
            {
                conditionText.alignment = TextAnchor.MiddleCenter;
                conditionText.fontSize = 40;
                conditionText.text = "Sorry, you lost.\n(Press R to try again)";
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
