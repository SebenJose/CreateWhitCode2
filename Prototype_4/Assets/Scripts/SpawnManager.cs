using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    public GameObject powerUpPrefabs;
    public int enemyCount;
    public int waveNumber = 1;
    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerUpPrefabs, GenerateSpawnPosition(), powerUpPrefabs.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUpPrefabs, GenerateSpawnPosition(), powerUpPrefabs.transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemysToSpawn)
    {
        for(int i = 0; i < enemysToSpawn; i++)
        {
            Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(spawnRange, -spawnRange);
        float spawnPosZ = Random.Range(spawnRange, -spawnRange);

        Vector3 randonPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randonPos;
    }
}
