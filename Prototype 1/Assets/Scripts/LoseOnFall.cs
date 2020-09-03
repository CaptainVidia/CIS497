//Author: George Tang
//Assignment: Prototype 1
//Description: Forces the player to stay on the platform. If player falls off the platform the trigger
//             activates causing the player to lose

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseOnFall : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
