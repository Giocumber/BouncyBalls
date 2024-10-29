using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeedbackInputManager : MonoBehaviour
{
    public TMP_InputField feedbackInputField; // TextMeshPro InputField
    public TMP_Text characterCounterText;
    public int maxCharacters = 250;

    //public FeedbackOutputManager feedbackOutputManager;
    public NameInputManager nameInputManager;

    void Start()
    {
        feedbackInputField.characterLimit = maxCharacters;
        UpdateCharacterCount();
        feedbackInputField.textComponent.enableWordWrapping = true;

        feedbackInputField.onValueChanged.AddListener(delegate { UpdateCharacterCount(); });
    }

    void UpdateCharacterCount()
    {
        // Update the text to show current character count vs maximum allowed
        int currentLength = feedbackInputField.text.Length;
        characterCounterText.text = $"{currentLength}/{maxCharacters}";

        //Change color if max characters are reached
        if (currentLength >= maxCharacters)
            characterCounterText.color = HexCodeColor("#BA4444");
        else
            characterCounterText.color = HexCodeColor("#F2F2F2");
    }

    private void OnDestroy()
    {
        // Unsubscribe when the object is destroyed to prevent memory leaks
        feedbackInputField.onValueChanged.RemoveListener(delegate { UpdateCharacterCount(); });
    }

    public void SubmitFeedback()
    {
        string feedbackText = feedbackInputField.text;

        if (!string.IsNullOrEmpty(feedbackText))
        {
            nameInputManager.playerFeedback = feedbackText;
            feedbackInputField.text = ""; // Clear input after submission
        }
    }

    private Color HexCodeColor(string hexCode)
    {
        Color customColor;
        if (ColorUtility.TryParseHtmlString(hexCode, out customColor))
            return customColor;
        else
            return Color.black;
    }
}
