using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    public float moveSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(HorizontalInput, VerticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    
    }

   
}
