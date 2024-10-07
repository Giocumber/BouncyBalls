using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;

    public Transform groundCheck;        // Reference to the position for ground checking
    public float jumpForce = 10f;        // Jump force
    public float groundCheckRadius = 0.2f;  // Radius for checking if grounded
    public LayerMask whatIsGround;       // Layer of ground
    public bool isGrounded;             // Is the player grounded

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Jump when the player presses the space key and is grounded
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);  // Apply jump force
        }

    }

    // Optional: Draw the ground check in the Scene view
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
