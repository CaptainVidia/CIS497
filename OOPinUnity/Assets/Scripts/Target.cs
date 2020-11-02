/*  George Tang
 *  Assignement 6
 * if object is shot and then dies object is destroyed
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int score = 0;
    public float health = 50f;
    public static bool win = false;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
            score++;
        }
    }

    private void Die()
    {
        score++;
        Destroy(gameObject);
    }

}
