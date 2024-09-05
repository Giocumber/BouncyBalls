using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AcornHitSpike : MonoBehaviour
{
    public bool isHit;

    private void Start()
    {
        isHit = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            isHit = true;
        }
    }
}
