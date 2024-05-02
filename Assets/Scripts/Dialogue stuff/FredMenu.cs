using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FredMenu : MonoBehaviour
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
            button2.text = "Well i suppose i will ";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Oh hello there sir you must be new, could you fetch me some apples for my stew i cant be bothered to get some but would be lovely";
        }
        else if (stats.activequestnum == 3)
        {
            if(stats.applechocie == 1)
            {
                button1.text = "Here have the apples (- 5 apples)";
                button2.text = "Here i have the apples but i want some sort of payment thanks( +40 coins)";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh lovely please give me 5 apples when you have gotten them";
            }
            else if(stats.applechocie == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Why would you help the peasant over me? Leave my sight";
            }

        }
        else if (stats.activequestnum == 4)
        {
            if(stats.npc2 == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh its the charity worker, the queen wants to talk";
            }
            else if (stats.npc2 == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello the queen was requesting you ";
            }
            else
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello friend the apple stew was lovely i appreciate the help friend";
            }
            
                    
        }
        else if (stats.activequestnum == 5)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 6)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 7)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 8)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 9)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 10)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
        }
        else if (stats.activequestnum == 11)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "";
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
            stats.determination += 0.1f;
            stats.charisma += 0.1f;
            stats.npc1 -= 1f;
            stats.npc2 += 1f;
            stats.applechocie = 1;
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
                if(inventory.apples >= 5)
                {
                    stats.activequestnum += 1;
                    inventory.apples -= 5;

                    stats.kindness += 0.3f;
                    stats.determination += 0.2f;

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

    public void buttontwopress()
    {
        if (stats.activequestnum == 1)
        {

        }
        else if (stats.activequestnum == 2)
        {
            stats.activequestnum += 1;
            stats.determination += 0.1f;
            stats.charisma += 0.1f;
            stats.npc1 -= 1f;
            stats.npc2 += 1f;
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
                    inventory.coins += 40;

                    stats.kindness -= 0.2f;
                    stats.empathy += 0.1f;
                    stats.honesty += 0.3f;
                    stats.npc2 -= 1f;

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
