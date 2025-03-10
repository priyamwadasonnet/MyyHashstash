using UnityEngine;

public class BotAI : MonoBehaviour
{
    public Transform ball;  // Assign the ball in the Inspector
    public float jumpForce = 5f;
    public float jumpDelay = 1f; // Time between jumps
    private Rigidbody2D rb;
    private float nextJumpTime = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.time >= nextJumpTime)
        {
            if (ball.position.y > transform.position.y - 1f) // Jump when ball is nearby
            {
                Jump();
                nextJumpTime = Time.time + jumpDelay + Random.Range(0f, 0.5f); // Random delay for natural AI
            }
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }
}
