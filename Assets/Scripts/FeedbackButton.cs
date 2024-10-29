using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackButton : MonoBehaviour
{
    public Button myButton; // Assign in the Inspector or find by script
    public string targetObjectName; // Set the name of the GameObject to enable

    // Start is called before the first frame update
    void Start()
    {
        myButton.onClick.AddListener(() => EnableGameObject());
    }

    void EnableGameObject()
    {
        GameObject targetObject = GameObject.Find(targetObjectName);

        if (targetObject != null)
        {
            targetObject.SetActive(true); // Enable the GameObject
            Debug.Log($"{targetObject.name} has been enabled.");
        }
        else
        {
            Debug.LogWarning($"GameObject '{targetObjectName}' not found!");
        }
    }
}
