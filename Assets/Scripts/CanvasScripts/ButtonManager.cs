using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    //private SaveGameObjectState saveGameObjectState;

    private void Start()
    {
        //saveGameObjectState = GameObject.FindGameObjectWithTag("FeedbackManager").GetComponent<SaveGameObjectState>();
    }

    public void StartButton()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void ExitGame()
    {
        //saveGameObjectState.SaveState();
        Application.Quit();
        Debug.Log("Exiting game");
    }
}
