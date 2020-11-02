/*  George Tang
 *  Assignement 6
 * shows the tutorial and instructions for game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialScripts : MonoBehaviour
{
    public Text tutorialText;

    // Start is called before the first frame update
    protected virtual void Awake()
    {
        StartCoroutine(TutorialFuntions());
    }


    IEnumerator TutorialFuntions()
    {
        tutorialText.text = "Welcome Player to Tutorial. Your goal is to find the magic portal to win! Shoot boxes to get them out of your way! Press R to continue!";
        while (!Input.GetKeyDown(KeyCode.R))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "As you can see, you are able to look around by moving the mouse.";

        while (!Input.GetKeyDown(KeyCode.R))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Use WASD to move around the map. Click the left mouse button to fire at boxes!";

        while (!Input.GetKeyDown(KeyCode.R))
        {
            yield return null;
        }

        yield return null;

        tutorialText.text = "Find the Magic Portal to win HINT: Red Boxes lead to the portal FOLLOW them";

        while (!Input.GetKeyDown(KeyCode.R))
        {
            yield return null;
        }


        tutorialText.text = "";

        yield break;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
