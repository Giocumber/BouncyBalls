using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlayer : MonoBehaviour
{
    public float shrinkSpeed = 0.1f;  // The speed at which the object shrinks
    public float minimumScale = 0.1f; // The minimum scale the object can shrink to
    public bool canShrink; // The minimum scale the object can shrink to

    private void Start()
    {
        canShrink = false;
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    void Update()
    {
        // Check if the object scale is greater than the minimum allowed scale
        if (canShrink && transform.localScale.x > minimumScale && transform.localScale.y > minimumScale)
        {
            // Calculate the new scale
            Vector3 newScale = transform.localScale - new Vector3(shrinkSpeed, shrinkSpeed, 0) * Time.deltaTime;

            // Apply the new scale to the object, ensuring it doesn't go below the minimum scale
            newScale.x = Mathf.Max(newScale.x, minimumScale);
            newScale.y = Mathf.Max(newScale.y, minimumScale);

            transform.localScale = newScale;
        }
    }
}
