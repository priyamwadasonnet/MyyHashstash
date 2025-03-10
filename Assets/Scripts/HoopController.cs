using UnityEngine;

public class HoopController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Tap or click
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
