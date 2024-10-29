using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObtain : MonoBehaviour
{
    private DoorEnter doorEnter;

    private void Start()
    {
        doorEnter = GameObject.Find("Door").GetComponent<DoorEnter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Key"))
        {
            doorEnter.canEnter = true;
            collision.gameObject.SetActive(false);
        }
    }
}
