using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFolloPlayer : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset = new Vector3(0, 5, -10);
   
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
