using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornAddBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canBounceForce;
    public float bounceForce;


    private void Start()
    {
        canBounceForce = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && canBounceForce)
        {
            AddBounceForce();
        }
    }

    private void AddBounceForce()
    {
        Invoke("BounceForceCD", 2f);
        canBounceForce = false;

        Vector2 bounce = Vector2.up * bounceForce;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(bounce, ForceMode2D.Impulse); // .Force .Impulse .Acceleration .VelocityChange
    }

    private void BounceForceCD()
    {
        canBounceForce = true;
    }
}
