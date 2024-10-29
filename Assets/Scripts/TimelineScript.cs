using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineScript : MonoBehaviour
{
    public float cutSceneTime;

    private void Start()
    {
        Invoke("LoadNextScene", cutSceneTime);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
