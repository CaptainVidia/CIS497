//Author: George Tang
//Assignment: Challenge 1
//Description: If the player enters the specific trigger zone, one point is added to the    
 //            player's score.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
