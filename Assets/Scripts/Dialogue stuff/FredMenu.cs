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
                Dialogue.text = "Oh hello friend the apple stew was lovely i appreciate the help friend, The queen wanted to see you i think";
            }
            
                    
        }
        else if (stats.activequestnum == 5)
        {
            if (stats.npc2 == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh its you, Bill wanted to talk go see him i dont want to talk to you";
            }
            else if (stats.npc2 == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello there bills in the market if u are looking for him ";
            }
            else
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello friend Bills waiting in the market i think he wanted your help";
            }
        }
        else if (stats.activequestnum == 6)
        {
            if (stats.npc2 == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Go do your work for bill peasant i dont want to see you";
            }
            else if (stats.npc2 == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh its kind you are helping bill good luck, wood can be found in the woods you can gather some";
            }
            else
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello friend if you are looking for wood i reccomend the woods i wish i could help";
            }
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
            statChangeDisplay.DisplayStatChange("Determination: +0.1", Color.green);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.1", Color.green);
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
                    statChangeDisplay.DisplayStatChange("Kindness: +0.3", Color.green);
                    stats.determination += 0.2f;
                    statChangeDisplay.DisplayStatChange("Determination: +0.2", Color.green);
                    stats.empathy -= 0.4f;
                    statChangeDisplay.DisplayStatChange("Empathy: -0.4", Color.red);

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
            statChangeDisplay.DisplayStatChange("Determination: +0.1", Color.green);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.1", Color.green);
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

                    stats.kindness -= 0.3f;
                    statChangeDisplay.DisplayStatChange("Kindess: -0.3", Color.red);
                    stats.empathy -= 0.3f;
                    statChangeDisplay.DisplayStatChange("Empathy: -0.3", Color.red);
                    stats.honesty += 0.3f;
                    statChangeDisplay.DisplayStatChange("Honesty: +0.3", Color.green);
                    stats.npc2 -= 1f;
                    stats.determination -= 0.2f;
                    statChangeDisplay.DisplayStatChange("Determiantion: -0.2", Color.red);



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
