/*
 * Name: George Tang
 * Assignment: 3D Prototype and First Person
 * Description: Allows the player to move and controls aspects of player
 * */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //mouse look variables
    public CharacterController controller;
    public float speed = 12f;

    //gravity variables
    public Vector3 velocity;
    public float gravity = -9.18f;
    public float gravityMultipiler = 2f;

    //variables for checking if on ground
    //adding gravity variables
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    // jumping variable
    public float jumpHeight = 3f;


    void Awake()
    {
        gravity *= gravityMultipiler;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        //we multply velocity but Time.deltaTime again to simulate gravity accelerating in a free fall
        controller.Move(velocity * Time.deltaTime);

        //check if player is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //reset gravity to a low number
        }

        //add jump code before we calculate gravity velocity
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //then after jumping we add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

    }
}
