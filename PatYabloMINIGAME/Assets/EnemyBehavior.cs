using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15f) Destroy(gameObject);
        
   

    }
}
