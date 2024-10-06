using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObtain : MonoBehaviour
{
    public DoorEnter doorEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            doorEnter.canEnter = true;
            Debug.Log(doorEnter.canEnter);
            collision.gameObject.SetActive(false);
        }
    }
}
