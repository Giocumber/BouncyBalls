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
        sceneManager = GameObject.Find("SceneManager").GetComponent<SceneManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && canEnter)
        {
            sceneManager.LoadNextScene();
        }
    }

    //IEnumerator LoadNextSceneTransition()
    //{
    //    Debug.Log("sdas");

    //    int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    //    int nextSceneIndex = currentSceneIndex + 1;

    //    // Ensure the next scene index is valid

    //    transitionAnim.SetTrigger("End");
    //    yield return new WaitForSeconds(2f);

    //    if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
    //    {
    //        SceneManager.LoadScene(nextSceneIndex);
    //    }
    //}

    //public void LoadNextScene()
    //{
    //    StartCoroutine(LoadNextSceneTransition());
    //}
}
