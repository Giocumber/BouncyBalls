using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    public GameObject nextButton;
    public float nextButtonCD;

    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(false);
        Invoke("EnableButton", nextButtonCD);
    }

    private void EnableButton()
    {
        nextButton.SetActive(true);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
