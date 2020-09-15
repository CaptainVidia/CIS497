//Author: George Tang
//Assignment: Prototype 2
//Description: allow player to shoot prefab with spacebar

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefabs : MonoBehaviour
{
    public GameObject prefabToShoot;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
