using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float speed = 2f; // Speed of the enemy
    public float followRange = 10f; // Range within which the enemy will follow the player


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= followRange) ;
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
} 
