//Author: George Tang
//Assignment: Challenge 2
//Description: if dog hits ball then increment score by 1 and destroy ball

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        

        //destroy dog
        //Destroy(other.gameObject);

        //destroy ball
        Destroy(gameObject);
        DisplayScore.score++;
    }
}
