using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        
        if(movementX != 0f)
            rb.velocity = new Vector2(movementX * moveSpeed, rb.velocity.y);
    }
}
