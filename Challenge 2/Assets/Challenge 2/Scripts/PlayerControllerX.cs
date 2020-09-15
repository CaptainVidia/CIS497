//Author: George Tang
//Assignment: Challenge 2
//Description: space triggers to spawn dog and move forward

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // time the player needs to wait to fire again
    private float nextFire = 0; // time since start after player can fire again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time pass since last fire, sned dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; //reset nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
