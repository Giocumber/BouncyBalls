using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornBounce : MonoBehaviour
{
    public float bounceForce;
    private Rigidbody2D rb;
    public bool canBounceForce;

    private void Start()
    {
        canBounceForce = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canBounceForce)
        {
            AddBounceForce();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts.Length > 0)
        {
            Vector2 bounce = Vector2.up * bounceForce;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(bounce, ForceMode2D.Impulse); // .Force .Impulse .Acceleration .VelocityChange
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
