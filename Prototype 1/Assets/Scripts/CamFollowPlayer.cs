//Author: George Tang
//Assignment: Prototype 1
//Description: The main camera follows the player as the player moves.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
