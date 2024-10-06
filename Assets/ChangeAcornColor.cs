using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAcornColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public AcornBounce acornBounce;

    void Start()
    {
        // Get the SpriteRenderer component attached to the same GameObject
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Function to change the sprite color
    public void SetSpriteColor(Color newColor)
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = newColor; // Set the new color
        }
    }

    private void Update()
    {

        if (acornBounce.canBounceForce)
        {
            //Debug.Log("sda");
            SetSpriteColor(new Color(168 / 255f, 87 / 255f, 63 / 255f));
        }
        else
            SetSpriteColor(new Color(118f / 255f, 87f / 255f, 63f / 255f));

    }
}
