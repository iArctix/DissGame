using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryMenu : MonoBehaviour
{
    public InventoryStats inventory;
    public GameObject inventoryui;
    public GameObject gameplayui;
    public Camera PlayerCamera;

    public TextMeshProUGUI coins;
    public TextMeshProUGUI wood;
    public TextMeshProUGUI apples;
    void Update()
    {
        openmenu();
        inventorystats();
 
    }

    void openmenu()
    {
        if (Input.GetKeyDown(KeyCode.I) && !inventoryui.activeSelf)
        {
            inventoryui.SetActive(true);
            gameplayui.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;
            

        }
        else if (Input.GetKeyDown(KeyCode.I) && inventoryui.activeSelf)
        {
            inventoryui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;
           
        }
    }

    void inventorystats()
    {
        coins.text = "Coins : " + inventory.coins;
        wood.text = "Wood : " + inventory.wood;
        apples.text = "Apples : " + inventory.apples;
    }
}
