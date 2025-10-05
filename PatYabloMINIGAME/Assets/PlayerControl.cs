using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float HorizontalInput;
    public float moveSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * HorizontalInput);
    }

   
}
