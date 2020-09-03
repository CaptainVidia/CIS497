using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //attach to player
public class LoseOnFall : MonoBehaviour
{
 

    void Update ()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
