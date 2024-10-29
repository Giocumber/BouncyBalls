using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private DoorEnter doorEnter;

    private void Start()
    {
        doorEnter = GameObject.Find("Door").GetComponent<DoorEnter>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Acorn"))
        {
            doorEnter.canEnter = true;
            gameObject.SetActive(false);
        }
    }
}
