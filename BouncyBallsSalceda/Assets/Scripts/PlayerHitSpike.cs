using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitSpike : MonoBehaviour
{
    public GameObject startingPos;
    public GameObject acorn;
    public AcornHitSpike acornHitSpike;

    private void Update()
    {
        if (acornHitSpike.isHit)
        {
            ResetPosition();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        acornHitSpike.isHit = false;
        transform.position = startingPos.transform.position;
        acorn.transform.position = new Vector2(startingPos.transform.position.x, startingPos.transform.position.y + 2f);
    }
}
