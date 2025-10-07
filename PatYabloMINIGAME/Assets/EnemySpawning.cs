using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to spawn
    public float spawnInterval = 2f; // Time interval between spawns
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
