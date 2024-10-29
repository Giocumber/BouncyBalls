using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameObject topButton;
    public GameObject gate;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Acorn"))
        {
            topButton.SetActive(false);
            gate.SetActive(false);
        }
    }
}
