using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour
{
    public GameObject pausePanel;
    public Animator circleTransition;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }

    }

    IEnumerator LoadNextSceneTransition()
    {
        circleTransition.SetTrigger("End");

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Ensure the next scene index is valid
        yield return new WaitForSeconds(1.5f);


        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadNextSceneTransition());
    }

    public void ReloadCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting...");  // This line only appears in the editor.
    }
}
