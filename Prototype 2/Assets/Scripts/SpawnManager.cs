using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;
    public bool gameOver = false;
    public HealthSystem healthSystem;
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        SpawnRandomPrefab();
    //    }
    //}

    void SpawnRandomPrefab()
    {
        //generate index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }

    void Start()
    {
        //getting reference to health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //calling methold repeatedly ("method", startDelay, spawnInterval)
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabwithCoroutine());

    }

    IEnumerator SpawnRandomPrefabwithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 2.0f);

            yield return new WaitForSeconds(1.5f);
        }

       
    }
}
