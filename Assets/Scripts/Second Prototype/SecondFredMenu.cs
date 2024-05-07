using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecondFredMenu : MonoBehaviour
{
    public GameObject gameplayui;
    public GameObject dialogueui;
    public PersonalityStats stats;
    public GameObject PlayerCamera;

    public bool intrigger;

    //Dialogue ui features
    public TextMeshProUGUI button1;
    public TextMeshProUGUI button2;
    public TextMeshProUGUI button3;
    public TextMeshProUGUI button4;
    public TextMeshProUGUI Dialogue;

    public InventoryStats inventory;
    public StatChangeDisplay statChangeDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intrigger = false;
            dialogueui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;
        }
    }

    public void Update()
    {
        if (intrigger)
        {
            openmenu();
            dialogueoptions();
        }

    }

    void openmenu()
    {
        if (Input.GetKeyDown(KeyCode.E) && !dialogueui.activeSelf)
        {
            dialogueui.SetActive(true);
            gameplayui.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;


        }
        else if (Input.GetKeyDown(KeyCode.E) && dialogueui.activeSelf)
        {
            dialogueui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;

        }
    }
    void dialogueoptions()
    {
        if (stats.activequestnum == 1)
        {
            button1.text = " ";
            button2.text = " ";
            button3.text = " ";
            button4.text = " ";
            Dialogue.text = "Hey im fred welcome to town i think the queen nwants to talk";
        }
        else if (stats.activequestnum == 2)
        {
            button1.text = "Yes of course i will ";
            button2.text = " ";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh hello there sir you must be new, could you fetch me some apples for my stew i cant be bothered to get some but would be lovely";
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
                button1.text = "Here have the apples (- 5 apples)";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh lovely please give me 5 apples when you have gotten them";
            }
            else if (stats.applechocie == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "I think Bills waiting for your help";
            }

        }
        else if (stats.activequestnum == 4)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh hello the queen was requesting you ";

        }
        else if (stats.activequestnum == 5)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh hello there bills in the market if u are looking for him ";
        }
        else if (stats.activequestnum == 6)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh its kind you are helping bill good luck, wood can be found in the woods you can gather some";
        }
        else if (stats.activequestnum == 7)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh so you helped him out huh well the queen wants to hear from you again";
        }
        else if (stats.activequestnum == 8)
        {
            button1.text = "Yes i will go looking right away";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh hello the queen sent you thank heavens, i lost my sword in the forest could you maybe go find it for me i would appreciate it";
        }
        else if (stats.activequestnum == 9)
        {
            button1.text = "Here it is i found it";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Please return it to me it was in the woods when i last had it";
        }
        else if (stats.activequestnum == 10)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Thanks for the help i really appreciate it good sir, i think the queen wants to see you now you have completes your tasks";
        }
        else if (stats.activequestnum == 11)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "The queen wants to give you your verdict go talk to her good luck ";
        }
        else if (stats.activequestnum == 12)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }

    }
    public void buttononepress()
    {
        if (stats.activequestnum == 1)
        {

        }
        else if (stats.activequestnum == 2)
        {
            stats.activequestnum += 1;
           
            stats.applechocie = 1;
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
                if (inventory.apples >= 5)
                {
                    stats.activequestnum += 1;
                    inventory.apples -= 5;

                  

                }
            }
            else if (stats.applechocie == 2)
            {

            }
        }
        else if (stats.activequestnum == 4)
        {

        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {

        }
        else if (stats.activequestnum == 8)
        {
            stats.activequestnum++;
           
        }
        else if (stats.activequestnum == 9 && inventory.swordfound)
        {
            stats.activequestnum++;
           

        }
        else if (stats.activequestnum == 10)
        {

        }
        else if (stats.activequestnum == 11)
        {

        }
        else if (stats.activequestnum == 12)
        {

        }
    }

    public void buttontwopress()
    {
        if (stats.activequestnum == 1)
        {

        }
        else if (stats.activequestnum == 2)
        {
           
        }
        else if (stats.activequestnum == 3)
        {
           
        }
        else if (stats.activequestnum == 4)
        {

        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {

        }
        else if (stats.activequestnum == 8)
        {
          
        }
        else if (stats.activequestnum == 9)
        {
          

        }
        else if (stats.activequestnum == 10)
        {

        }
        else if (stats.activequestnum == 11)
        {

        }
        else if (stats.activequestnum == 12)
        {

        }
    }
    public void buttonthreepress()
    {
        if (stats.activequestnum == 1)
        {

        }
        else if (stats.activequestnum == 2)
        {

        }
        else if (stats.activequestnum == 3)
        {

        }
        else if (stats.activequestnum == 4)
        {

        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {

        }
        else if (stats.activequestnum == 8)
        {

        }
        else if (stats.activequestnum == 9)
        {
            





        }
        else if (stats.activequestnum == 10)
        {

        }
        else if (stats.activequestnum == 11)
        {

        }
        else if (stats.activequestnum == 12)
        {

        }
    }
    public void buttonfourpress()
    {
        if (stats.activequestnum == 1)
        {

        }
        else if (stats.activequestnum == 2)
        {

        }
        else if (stats.activequestnum == 3)
        {

        }
        else if (stats.activequestnum == 4)
        {

        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {

        }
        else if (stats.activequestnum == 8)
        {

        }
        else if (stats.activequestnum == 9)
        {

        }
        else if (stats.activequestnum == 10)
        {

        }
        else if (stats.activequestnum == 11)
        {

        }
        else if (stats.activequestnum == 12)
        {

        }
    }
}
