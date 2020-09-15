//Author: George Tang
//Assignment: Challenge 2
//Description: spawn dog and balls

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    
    //private float spawnInterval = 4.0f;

    //public bool gameOver = false;
    

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        
        StartCoroutine(SpawnRandomPrefabwithCoroutine());

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //spawnInterval = Random.Range(2, 4);
        int index = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
    }
    IEnumerator SpawnRandomPrefabwithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!DisplayScore.gameOver)
        {
            float randomDelay = Random.Range(3,5);

            yield return new WaitForSeconds(1.5f);

            SpawnRandomBall();
        }

       

       
    }


}
