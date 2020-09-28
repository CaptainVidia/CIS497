//Author: George Tang
//Assignment: Prototype 3
//Description: Trigger Zones. if trigger zones are hit one point is added to the player's score

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}