using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    public bool canEnter;

    public string sceneName;

    private void Start()
    {
        canEnter = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && canEnter)
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("laog");
        }
    }
}
