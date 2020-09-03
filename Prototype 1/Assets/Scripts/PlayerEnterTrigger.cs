//Author: George Tang
//Assignment: Prototype 1
//Description: If a player enters the trigger zone, they will score a point. The point
//               is displayed on the top left corner.

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
