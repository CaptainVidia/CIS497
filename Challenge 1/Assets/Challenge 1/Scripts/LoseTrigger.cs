//Author: George Tang
//Assignment: Challenge 1
//Description: If the player goes above or below the walls, a trigger causes the player to lose. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 80 || transform.position.y <= -51)
        {
            ScoreManager.gameOver = true;
        }
    }
}
