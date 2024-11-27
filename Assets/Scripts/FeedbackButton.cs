using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackButton : MonoBehaviour
{
    private Button myButton; // Assign in the Inspector or find by script
    public string parentObjectTag; // Set the name of the GameObject to enable

    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(() => EnableGameObject());
    }

    void EnableGameObject()
    {
        GameObject parentObject = GameObject.FindGameObjectWithTag(parentObjectTag);

        if (parentObject != null)
        {
            Transform targetObject = parentObject.transform.GetChild(1);
            targetObject.gameObject.SetActive(true); // Enable the GameObject
        }
        else
        {
            Debug.LogWarning($"GameObject not found!");
        }
    }
}
