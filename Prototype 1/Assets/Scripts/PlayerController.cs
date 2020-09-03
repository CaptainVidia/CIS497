﻿//Author: George Tang
//Assignment: Prototype 1
//Description: Allows the player to control the vehicle using real time and physics.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float forwardInput;
    public float horizontalInput;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.forward * Time .deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
