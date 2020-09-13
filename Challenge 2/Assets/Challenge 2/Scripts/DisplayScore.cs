using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DisplayScore: MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public bool gameOver = false;
    public bool won = false;
    //public GameObject winGameText;
    void Start()
    {
        //textbox = GetComponent<Text>();
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {            
        textbox.text = "Score: " + score;

        if (score >= 5)
        {
            won = true;
            gameOver = true;
           
        }

        if (gameOver)
        {
            if (won)
            {
            //winGameText.SetActive(true);
            textbox.text = "You Win!";
            }

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    
}


