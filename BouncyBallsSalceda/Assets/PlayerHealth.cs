using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject gameWin;
    public CameraMovement cameraMovement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
            PlayerDead();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            Destroy(gameObject);
            PlayerDead();
        }

        if (collision.CompareTag("WinningPlatform"))
        {
            PlayerWin();
            Debug.Log("sdasd");
        }
    }


    public void PlayerWin()
    {
        gameWin.SetActive(true);
        Time.timeScale = 0;
    }

    public void PlayerDead()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0;
        cameraMovement.enabled = false;
    }
}
