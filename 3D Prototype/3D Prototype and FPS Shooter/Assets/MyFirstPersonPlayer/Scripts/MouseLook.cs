/*
 * Name: George Tang
 * Assignment: 3D Prototype and First Person
 * Description: controls the mouse look up and down. Also restricts boundaries of look up and down.
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;
    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //get mouse input and assign it to two floats
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player GameObject with horizontal mouse input 
        player.transform.Rotate(Vector3.up * mouseX);

        //rotate camera around the x axis with vertical mouse input
        verticalLookRotation -= mouseY;
        //clamp the rotation so the player does not over rotate and look behind themselves upside down
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        //apply roation based on clamped input
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
}
