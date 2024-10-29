using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class FeedbackOutputManager : MonoBehaviour
{
    private TMP_Text feedbackDisplayText; // TextMeshPro Text for displaying feedback
    private TMP_Text playerNameDisplayText; // TextMeshPro Text for displaying playername

    public GameObject feedbackCardPrefab;
    public GameObject contentParentObject;

    private TMP_Text feedbackTitle;

    private void Start()
    {
        feedbackTitle = GameObject.Find("FeedbackTitle").GetComponent<TMP_Text>();
        DisplayFeedbackCount();
    }

    private void DisplayFeedbackCount()
    {
        if (contentParentObject.transform.childCount == 0)
            feedbackTitle.text = "No feedbacks yet!";
        else
            feedbackTitle.text = "Feedbacks!";
    }

    public void CreateFeedbackCard(string feedbackText, string playerName)
    {
        GameObject feedbackCard = Instantiate(feedbackCardPrefab, transform.position, transform.rotation);
        feedbackDisplayText = feedbackCard.transform.GetChild(0).GetComponent<TMP_Text>();
        feedbackDisplayText.text = feedbackText;

        playerNameDisplayText = feedbackCard.transform.GetChild(2).GetComponent<TMP_Text>();
        playerNameDisplayText.text = playerName;

        feedbackCard.transform.SetParent(contentParentObject.transform, false); // Setting as child with `worldPositionStays` false
        feedbackCard.transform.localScale = Vector3.one; // Ensure scale is (1,1,1)

        DisplayFeedbackCount();
    }

}
