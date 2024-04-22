using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PickupUI : MonoBehaviour
{
    public GameObject pickupTextPrefab;
    public Transform canvasTransform; 
    public float displayDuration = 2f; 
    public float verticalSpacing = 10f; 

    private List<GameObject> activePickupMessages = new List<GameObject>(); 

   
    public void DisplayPickup(string itemName, int amount)
    {
       
        GameObject pickupTextObject = Instantiate(pickupTextPrefab, canvasTransform);

     
        TextMeshProUGUI textComponent = pickupTextObject.GetComponent<TextMeshProUGUI>();
        if (textComponent != null)
        {
            textComponent.text = itemName + " x" + amount; 
        }

       
        activePickupMessages.Add(pickupTextObject);
        PositionPickupMessages();

       
        Destroy(pickupTextObject, displayDuration);
    }

    // Position pickup messages
    private void PositionPickupMessages()
    {
        float currentYPosition = 0;
        for (int i = activePickupMessages.Count - 1; i >= 0; i--)
        {
            GameObject pickupMessage = activePickupMessages[i];
            if (pickupMessage != null)
            {
                RectTransform rectTransform = pickupMessage.GetComponent<RectTransform>();
                if (rectTransform != null)
                {
                   
                    rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, currentYPosition);
                    currentYPosition += rectTransform.sizeDelta.y + verticalSpacing;
                }
            }
            else
            {
               
                activePickupMessages.RemoveAt(i);
            }
        }
    }

    
    public void RemovePickupMessage(GameObject pickupMessage)
    {
        activePickupMessages.Remove(pickupMessage);
        PositionPickupMessages();
    }
}

