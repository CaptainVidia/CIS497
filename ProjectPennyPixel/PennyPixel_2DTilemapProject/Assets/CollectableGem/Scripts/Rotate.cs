using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private UIManager uIManager;
    private bool triggered = false;
    public float speed = 5;
	public Vector3 rotateDirection;

	void Update()
    {
		transform.Rotate (rotateDirection * speed * Time.deltaTime);
	}
    
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
            ScoreManager.score++;
        }
    }
}
