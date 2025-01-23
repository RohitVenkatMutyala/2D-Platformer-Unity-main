using UnityEngine;
using TMPro; // For TextMeshPro
using System.Collections; // For Coroutine

public class NarrativeDisplay : MonoBehaviour
{
    public TextMeshProUGUI narrativeText; // Drag your TextMeshPro element here
    public string[] narrativeSentences; // Array of sentences to display
    private int currentSentenceIndex = 0;
    public float sentenceDelay = 0.5f; // Time delay between sentences (in seconds)

    void Start()
    {
        if (narrativeSentences.Length > 0)
        {
            narrativeText.text = narrativeSentences[currentSentenceIndex];
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for mouse click
        {
            // Start showing the next sentence (with a delay if needed)
            ShowNextSentence();
        }
    }

    void ShowNextSentence()
    {
        currentSentenceIndex++;

        if (currentSentenceIndex < narrativeSentences.Length)
        {
            // Start a coroutine to display the next sentence with a delay
            StartCoroutine(DisplaySentenceWithDelay(narrativeSentences[currentSentenceIndex]));
        }
        else
        {
            // Optionally, you could disable the text or transition here
            narrativeText.text = ""; // Clear text or handle end of narrative
            // Add your logic to transition to the next scene, or any other behavior.
        }
    }

    IEnumerator DisplaySentenceWithDelay(string sentence)
    {
        narrativeText.text = ""; // Clear previous text for smooth transition

        foreach (char letter in sentence)
        {
            narrativeText.text += letter; // Add one letter at a time
            yield return new WaitForSeconds(sentenceDelay); // Wait for a short time before showing the next letter
        }
    }
}
