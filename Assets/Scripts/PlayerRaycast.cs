using UnityEngine;
using TMPro;

public class PlayerRaycast : MonoBehaviour
{
    public float raycastDistance = 10f; // Distance for the raycast
    private Camera playerCamera; // Reference to the player's camera
    private GameObject lastHitObject; // Reference to the last object hit by the raycast

    public GameObject prompt;
    public TextMeshProUGUI prompttext;

    public InventoryStats inventory;

    void Start()
    {
        // Find the player's camera
        playerCamera = GetComponentInChildren<Camera>();
        if (playerCamera == null)
        {
            Debug.LogError("PlayerRaycast script requires a camera as a child of the player.");
        }
    }

    void Update()
    {
        // Make sure playerCamera is not null
        if (playerCamera == null)
            return;

        // Cast a ray from the camera's position forward
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, raycastDistance))
        {
            // Check what type of object the ray hits and call the appropriate function
            if (hit.collider.CompareTag("Apple"))
            {
                if (hit.collider.gameObject != lastHitObject)
                {
                    AppleHit();
                    lastHitObject = hit.collider.gameObject;
                }
            }
            else if (hit.collider.CompareTag("Coin"))
            {
                if (hit.collider.gameObject != lastHitObject)
                {
                    CoinHit();
                    lastHitObject = hit.collider.gameObject;
                }
            }
            else if (hit.collider.CompareTag("Wood"))
            {
                if (hit.collider.gameObject != lastHitObject)
                {
                    WoodHit();
                    lastHitObject = hit.collider.gameObject;
                }
            }
        }
        else
        {
            // If no object is hit by the raycast, call the appropriate function for the last hit object
            if (lastHitObject != null)
            {
                if (lastHitObject.CompareTag("Apple"))
                {
                    AppleNotHit();
                }
                else if (lastHitObject.CompareTag("Coin"))
                {
                    CoinNotHit();
                }
                else if (lastHitObject.CompareTag("Wood"))
                {
                    WoodNotHit();
                }
                lastHitObject = null;
            }
        }
        // Check for player input to delete apple
        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractPressed();
        }
    }

    void AppleHit()
    {
        Debug.Log("Apple was hit!");
        prompttext.text = "Press E TO Pickup Apple";
        prompt.SetActive(true);

    }

    void CoinHit()
    {
        Debug.Log("CoinHit function called!"); // Check if the function is called
        Debug.Log("Coin was hit!");
        prompttext.text = "Press E TO Pickup Coins";
        prompt.SetActive(true);
        Debug.Log("Coin prompt activated!"); // Check if the prompt activation is reached
    }

    void WoodHit()
    {
        Debug.Log("Wood was hit!");
        prompttext.text = "Press E TO Pickup Wood";
        prompt.SetActive(true);
    }

    void AppleNotHit()
    {
        Debug.Log("Apple is no longer hit!");
        prompttext.text = " ";
        prompt.SetActive(false);
    }

    void CoinNotHit()
    {
        Debug.Log("Coin is no longer hit!");
        prompttext.text = " ";
        prompt.SetActive(false);
    }

    void WoodNotHit()
    {
        Debug.Log("Wood is no longer hit!");
        prompttext.text = " ";
        prompt.SetActive(false);
    }

    void InteractPressed()
    {
        if (lastHitObject != null && lastHitObject.CompareTag("Apple"))
        {
            Destroy(lastHitObject);
            inventory.apples++;
            
            prompt.SetActive(false); // Deactivate prompt after deleting the apple
        }
        else if (lastHitObject != null && lastHitObject.CompareTag("Coin"))
        {
            Destroy(lastHitObject);
            inventory.coins++;
            prompt.SetActive(false);
        }
        else if (lastHitObject!=null && lastHitObject.CompareTag("Wood"))
        {
            Destroy(lastHitObject);
            inventory.wood++;
            prompt.SetActive(false);
        }
        else
        {
            return;
        }
    }
}