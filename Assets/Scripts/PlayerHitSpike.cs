using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitSpike : MonoBehaviour
{
    //public GameObject startingPos;
    //public GameObject acorn;
    public AcornHitSpike acornHitSpike;

    public string sceneName;

    private void Update()
    {
        if (acornHitSpike.isHit)
        {
            //ResetPosition();
            ResetScene();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            //ResetPosition();
            ResetScene();
        }
    }

    //private void ResetPosition()
    //{
    //    acornHitSpike.isHit = false;
    //    transform.position = startingPos.transform.position;
    //    acorn.transform.position = new Vector2(startingPos.transform.position.x, startingPos.transform.position.y + 2f);
    //}

    private void ResetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
