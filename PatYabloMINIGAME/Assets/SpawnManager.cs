using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        private float spawnRangeX = 27f;
    private float spawnPosZ = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W)) {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int enemyIndex = Random.Range(0, enemyPrfabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos),
                enemyPrefabs[enemyIndex].transform.rotation); }
    }
}
