using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class StatChangeDisplay : MonoBehaviour
{
    public TextMeshProUGUI statChangeText;
    public float displayDuration = 2f;
    public float displaySpacing = 30f;
    public int maxDisplayedChanges = 5;

    private List<(string, Color)> statChangeList = new List<(string, Color)>();
    private Coroutine displayCoroutine;

    // Function to display stat changes on the screen with specified color
    public void DisplayStatChange(string statChange, Color color)
    {
        if (statChangeList.Count >= maxDisplayedChanges)
        {
            return;
        }

        statChangeList.Add((statChange, color));

        // Display stat changes immediately
        DisplayStatChanges();
    }

    private void DisplayStatChanges()
    {
        // Clear previous stat changes
        statChangeText.text = "";

        // Append all stat changes with specified color
        foreach ((string statChange, Color color) in statChangeList)
        {
            statChangeText.text += $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{statChange}</color>\n";
        }

        // Start coroutine to clear the text after duration
        if (displayCoroutine != null)
        {
            StopCoroutine(displayCoroutine);
        }
        displayCoroutine = StartCoroutine(ClearStatChanges());
    }

    // Coroutine to clear the stat change text after a certain duration
    private IEnumerator ClearStatChanges()
    {
        yield return new WaitForSeconds(displayDuration);

        statChangeText.text = ""; // Clear the text after the duration

        statChangeList.Clear(); // Clear the stat changes list

        displayCoroutine = null; // Reset coroutine reference
    }
}