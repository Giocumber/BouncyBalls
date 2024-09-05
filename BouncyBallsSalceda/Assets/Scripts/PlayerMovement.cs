using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX= Input.GetAxis("Horizontal");
        //float movementY = Input.GetAxis("Vertical");

        //rb.velocity = new Vector2(movementX * moveSpeed, movementY * moveSpeed);
        rb.velocity = new Vector2(movementX * moveSpeed, rb.velocity.y);



    }


}
