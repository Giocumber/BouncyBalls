using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackManagerScript : MonoBehaviour
{
    private static FeedbackManagerScript instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this; // Set the static instance to this instance
            DontDestroyOnLoad(gameObject); // Make this object persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy any duplicate instances
        }
    }

}
