using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    private DoorEnter doorEnter;
    public GameObject keyVFX;
    private AudioManager audioManager;

    private void Start()
    {
        doorEnter = GameObject.Find("Door").GetComponent<DoorEnter>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") || collision.CompareTag("Acorn"))
        {
            audioManager.PlaySFX(audioManager.keySFX);
            doorEnter.canEnter = true;
            Instantiate(keyVFX, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}
