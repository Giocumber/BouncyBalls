using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcornAddBounce : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canBounceForce;
    public float bounceForce;
    public GameObject acornVFX;

    private AudioManager audioManager;

    private void Start()
    {
        canBounceForce = true;
        rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && canBounceForce)
        {
            Vector3 acornVFXPosition = transform.position + new Vector3(0f, 1f, 0f);
            Instantiate(acornVFX, acornVFXPosition, Quaternion.identity);
            AddBounceForce();
        }
    }

    private void AddBounceForce()
    {
        audioManager.PlaySFX(audioManager.acornAddBounceSFX);
        canBounceForce = false;

        Vector2 bounce = Vector2.up * bounceForce;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(bounce, ForceMode2D.Impulse); // .Force .Impulse .Acceleration .VelocityChange

        Invoke("BounceForceCD", 2f);
    }

    private void BounceForceCD()
    {
        canBounceForce = true;
    }
}
