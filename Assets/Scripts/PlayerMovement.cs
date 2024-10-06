using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    private bool isFacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX= Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementX * moveSpeed, rb.velocity.y);

        // Flip the player based on movement direction
        if (movementX > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (movementX < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        // Toggle the direction the player is facing
        isFacingRight = !isFacingRight;

        // Multiply the player's local scale x by -1 to flip the sprite
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
