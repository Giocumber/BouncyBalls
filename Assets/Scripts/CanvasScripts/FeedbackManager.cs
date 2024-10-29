using UnityEngine;
using System.IO;
using TMPro;

public class FeedbackManager : MonoBehaviour
{
    public TMP_InputField feedbackInputField; // TextMeshPro InputField
    private TMP_Text feedbackDisplayText; // TextMeshPro Text for displaying feedback

    private string feedbackFilePath;

    public GameObject feedbackCardPrefab;
    public GameObject contentParentObject;


    private void Awake()
    {
        feedbackInputField.textComponent.enableWordWrapping = true;
    }

    void Start()
    {
        feedbackDisplayText = feedbackCardPrefab.transform.GetChild(0).GetComponent<TMP_Text>();
        feedbackFilePath = Application.persistentDataPath + "/feedback.txt"; //creates a file
        LoadFeedback();
        //ClearFeedback();
    }

    public void SubmitFeedback()
    {
        string feedbackText = feedbackInputField.text;
        if (!string.IsNullOrEmpty(feedbackText))
        {
            File.AppendAllText(feedbackFilePath, feedbackText);
            feedbackInputField.text = ""; // Clear input after submission
            CreateFeedbackCard();
            LoadFeedback(); // Refresh feedback display
        }
    }

    private void CreateFeedbackCard()
    {
        GameObject feedbackCard = Instantiate(feedbackCardPrefab);
        feedbackCard.transform.SetParent(contentParentObject.transform);
    }

    private void LoadFeedback()
    {
        if (File.Exists(feedbackFilePath))
        {
            feedbackDisplayText.text = File.ReadAllText(feedbackFilePath);
        }
        else
        {
            feedbackDisplayText.text = "No feedback yet!";
        }
    }

    public void ClearFeedback()
    {
        if (File.Exists(feedbackFilePath))
        {
            File.WriteAllText(feedbackFilePath, ""); // Clear file content
            feedbackDisplayText.text = "No feedback yet!"; // Update display
        }
    }

}
