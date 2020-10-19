using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    public Text scoreText;
    public static int score = 0;
    public static bool win = false;

    void Update()
    {
        if (!win)
        {
            scoreText.text = "Score: " + score;
        }
        else if (score >= 10)
        {
            scoreText.text = "You Win! All Gems Collected! Press R to Restart!";
        }
        else
        {
            scoreText.text = "Special Gem collected !\nCollected Gems " + score + " out of 10";
        }
        if (win && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gem"))
        {
            score++;
        }
        if (collision.CompareTag("SpecialGem"))
        {
            win = true;
        }
    }
}

