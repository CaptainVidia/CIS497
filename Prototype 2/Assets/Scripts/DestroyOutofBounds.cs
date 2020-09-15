//Author: George Tang
//Assignment: Prototype 2
//Description: dog doesnt hit ball decrease one heart and destroy ball

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < bottomBound)
        {
            //Debug.Log("Game Over!");
            //grab the health system script and call the TakeDamage ()
            healthSystemScript.TakeDamage();

            Destroy(gameObject);
        }

    }
}
