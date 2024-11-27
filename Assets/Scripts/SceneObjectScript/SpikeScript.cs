using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Acorn"))
        {
            PlayerDeath playerDeath = collision.gameObject.transform.parent.GetComponent<PlayerDeath>();
            if(playerDeath != null)
                playerDeath.Die();

            Invoke("ReloadCurrentScene", 1.5f);
        }
    }

    private void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

}
