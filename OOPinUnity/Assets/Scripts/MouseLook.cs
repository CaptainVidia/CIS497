/*  George Tang
 *  Assignement 6
 * Player can look around using the mouse
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    private float mouseX, mouseY, verticalLookRotation = 0f;
    public float sensitivity = 100f;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.transform.Rotate(Vector3.up * mouseX);

        //rotate camera around the x-axis with vertical look ratation
        verticalLookRotation -= mouseY;
        //clamp the rotation so the player doesn't over rotate
        //and look behind themselves upside down
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        //Apply rotation based on clamped output
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }

    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
