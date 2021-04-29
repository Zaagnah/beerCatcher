using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject [] DownObj;
    private float timeToSpawn = 1f;
    public float timeBetweenWaves = 10f;

    private void SpawnBeer()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomDrop = Random.Range(0, DownObj.Length);
        
        Instantiate(DownObj[randomDrop], spawnPoints[randomIndex].position, Quaternion.identity);
                 
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBeer();
            timeToSpawn = Time.time + timeBetweenWaves;

        }

    }
}
