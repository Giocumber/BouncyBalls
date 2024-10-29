using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class FeedbackOutputManager : MonoBehaviour
{
    private TMP_Text feedbackDisplayText; // TextMeshPro Text for displaying feedback

    public GameObject feedbackCardPrefab;
    public GameObject contentParentObject;

    private TMP_Text feedbackTitle;

    private void Start()
    {
        feedbackTitle = GameObject.Find("FeedbackTitle").GetComponent<TMP_Text>();
        DisplayFeedbackCount();

        //feedbackFilePath = Application.persistentDataPath + "/feedback.txt"; //creates a file
        //ClearFeedback();
    }

    private void DisplayFeedbackCount()
    {
        if (contentParentObject.transform.childCount == 0)
            feedbackTitle.text = "No feedbacks yet!";
        else
            feedbackTitle.text = "Feedbacks!";
    }

    //private void LoadFeedback()
    //{
    //    if (File.Exists(feedbackFilePath))
    //    { 
    //        feedbackDisplayText.text = File.ReadAllText(feedbackFilePath);
    //    }
    //}

    public void CreateFeedbackCard(string feedbackText)
    {
        GameObject feedbackCard = Instantiate(feedbackCardPrefab, transform.position, transform.rotation);
        feedbackDisplayText = feedbackCard.transform.GetChild(0).GetComponent<TMP_Text>();
        feedbackDisplayText.text = feedbackText;

        feedbackCard.transform.SetParent(contentParentObject.transform, false); // Setting as child with `worldPositionStays` false
        feedbackCard.transform.localScale = Vector3.one; // Ensure scale is (1,1,1)

        DisplayFeedbackCount();

        //LoadFeedback();
    }

}
