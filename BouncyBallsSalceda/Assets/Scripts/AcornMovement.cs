using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movementX * moveSpeed, rb.velocity.y);
    }
}
