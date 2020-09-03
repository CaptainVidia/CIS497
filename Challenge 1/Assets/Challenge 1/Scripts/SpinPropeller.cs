//Author: George Tang
//Assignment: Challenge 1
//Description: Simple update to make the propeller on the plane roatate.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{

    // rotating on the propeller
    void Update()
    {
        transform.Rotate(Vector3.forward, 40);
    }
}
