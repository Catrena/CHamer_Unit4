using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 8.5f;
    // Start is called before the first frame update
    void Start()
    {
        /* float xPos = Random.Range(-spawnRange, spawnRange);
         float zPos = Random.Range(-spawnRange, spawnRange);
         Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos); moved because GSP will generate*/

       // Vector3 genPos = GenerateSpawnPosition(); //return types
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation); //remove static position new Vector3(6, 0, 6)
    }

    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRange, spawnRange);
        float zPos = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos);
        return spawnPos;
    }
    // Update is called once per frame
    void Update()
    {
       //Instantiate(enemyPrefab, new Vector3(6, 0, 6), enemyPrefab.transform.rotation); moved to start to instantiate just once
    }
}
