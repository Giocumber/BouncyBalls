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

    public GameObject jumpVfx;
    private AudioManager audioManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  // Get the Rigidbody2D component
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Jump when the player presses the space key and is grounded
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            audioManager.PlaySFX(audioManager.playerJumpSFX);
            Vector3 jumpVFXPosition = transform.position + new Vector3(0f, 0.5f, 0f);
            Instantiate(jumpVfx, jumpVFXPosition, Quaternion.identity);
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
