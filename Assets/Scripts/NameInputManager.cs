using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInputManager : MonoBehaviour
{
    private TMP_InputField playerNameInputField;

    public TMP_Text characterCounterText;
    public int maxCharacters = 20;

    public FeedbackOutputManager feedbackOutputManager;
    public string playerFeedback;

    public GameObject doneButton;

    void Start()
    {
        playerNameInputField = GetComponent<TMP_InputField>();

        playerNameInputField.characterLimit = maxCharacters;
        UpdateCharacterCount();
        playerNameInputField.textComponent.enableWordWrapping = true;

        playerNameInputField.onValueChanged.AddListener(delegate { UpdateCharacterCount(); });
    }

    void UpdateCharacterCount()
    {
        // Update the text to show current character count vs maximum allowed
        int currentLength = playerNameInputField.text.Length;
        characterCounterText.text = $"{currentLength}/{maxCharacters}";

        string input = playerNameInputField.text;
        ButtonAppearance(input);

        //Change color if max characters are reached
        if (currentLength >= maxCharacters)
            characterCounterText.color = HexCodeColor("#BA4444");
        else
            characterCounterText.color = HexCodeColor("#F2F2F2");
    }

    private void ButtonAppearance(string input)
    {
        // Check if the input is not null, not empty, and does not consist only of whitespace characters
        if (!string.IsNullOrWhiteSpace(input))
            doneButton.SetActive(true);
        else
            doneButton.SetActive(false);
    }

    public void SubmitPlayerName()
    {
        string playerName = playerNameInputField.text;

        if (!string.IsNullOrEmpty(playerName))
        {
            feedbackOutputManager.CreateFeedbackCard(playerFeedback,playerName);
            playerNameInputField.text = ""; // Clear input after submission
        }
    }

    private void OnDestroy()
    {
        // Unsubscribe when the object is destroyed to prevent memory leaks
        playerNameInputField.onValueChanged.RemoveListener(delegate { UpdateCharacterCount(); });
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
