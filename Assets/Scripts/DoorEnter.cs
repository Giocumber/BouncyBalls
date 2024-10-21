using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    public bool canEnter;
    //public Animator transitionAnim;
    private SceneManagerScript sceneManager;

    private void Start()
    {
        canEnter = false;
        sceneManager = GameObject.Find("UI_Canvas").GetComponent<SceneManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && canEnter)
        {
            //ShrinkPlayer shrinkPlayer = GameObject.Find("PlayerAndAcorn").GetComponent<ShrinkPlayer>();
            //shrinkPlayer.canShrink = true;
            sceneManager.LoadNextScene();
        }
    }


}
