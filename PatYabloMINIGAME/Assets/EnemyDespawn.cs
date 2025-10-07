using UnityEngine;

public class EnemyDespawn : MonoBehaviour
{
    public float despawnTime = 10f; // Time in seconds before despawning
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Schedule the enemy to despawn after a set time
        Invoke("Despawn", despawnTime);
    }

    // Update is called once per frame
    void Despawn()
    {
        // Destroy the enemy GameObject
        Destroy(gameObject);
    }
}
