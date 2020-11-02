/*  George Tang
 *  Assignement 6
 * Trigger Zone and Target are parent and child this way player can shoot boxes without triggering anything
 because text is cleared and no score is tracked only if player find the portal. Shooting boxes does keep a
 a score but score text will not show because main focus is finding the portal.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : Target
{
    
    public Text text;

    // Update is called once per frame
    void Start()
    {
        text.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            text.text = "Magic portal Found! You win!";
        }

        if (other.CompareTag("TriggerLose"))
        {
            text.text = "Fake Portal Found! Find the real one!";
        }
    }
}