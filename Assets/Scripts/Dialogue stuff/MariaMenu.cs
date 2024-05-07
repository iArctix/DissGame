using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MariaMenu : MonoBehaviour
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
        if(stats.activequestnum == 1)
        {
            button1.text = "Okay i happily will thankyou for the welcome";
            button2.text = "Okay i guess";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Hello Welcome to my town to live here you may have to do some tasks first. Please go either help the villager or the peasant ";
        }
        else if (stats.activequestnum == 2)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Yeah well you will find villager fred next to me in the town or venture to the market to find peasant Bill";
        }
        else if(stats.activequestnum == 3)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Come talk to me later after you have finished your task";
        }
        else if(stats.activequestnum == 4)
        {
            button1.text = "Okay i will happily go talk i want to live here";
            button2.text = "Why would i want to live here anyway but okay fine";
            button3.text = "Okay if i help could you make it worth my while? (+20 coins) (Need 0.8 charisma)";
            button4.text = "";
            Dialogue.text = "Hello there thanks for helping my villager, if you want to live here more work must be done, now next i want you to help bill he wanted to talk";
        }
        else if (stats.activequestnum == 5)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Bill is waiting in the market for you return later when you have finished";
        }
        else if (stats.activequestnum == 6)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "You still havent helped Bill come back when you have finished";
        }
        else if (stats.activequestnum == 7)
        {
            button1.text = "Okay sounds good queen i will go help";
            button2.text = "Another chore when will i be free...";
            button3.text = "";
            button4.text = "";
            if (stats.npc1 == 1)
            {
                Dialogue.text = "Well you helped him but in a not very nice way we dont like that kind of behaviour here!! Anyway next i want you to help out fred find him in town near me";
            }
            else if (stats.npc1 == 2)
            {
                Dialogue.text = "Thanks for helping him out thats kind of you. Anyway next i want you to help out fred find him in town near me ";
            }
            else
            {
                Dialogue.text = "You have been really kind to Bill he sees you as a friend now  Anyway next i want you to help out fred find him in town near me";
            }
        }
        else if (stats.activequestnum == 8)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Fred is in the town near me he wants your help, this will be your last task";
        }
        else if (stats.activequestnum == 9)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Complete freds taska nd then return to me";
        }
        else if (stats.activequestnum == 10)
        {
            button1.text = "Yes queen im ready";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Ok so you ahve completed your tasks and i have made up my mind about you. Would you like to hear if i deem you worthy of living here?";
        }
        else if (stats.activequestnum ==11)
        {
           if(stats.overallstat > 4.5)
            {
                button1.text = "Back To Menu";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "After you have been through the town meeting my subjects ive heard nothing but good things of the way you handle yourself .I would glady allow you to live here and even better i will allow you to live in one of our already built houses to show my gratitude";
            }
           else if (stats.overallstat >= 3 && stats.overallstat <=4.5)
            {
                button1.text = "Back to Menu";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Overall you have been quote nice to my subjects and made a majority of good decsions and choices therefore i will allow you to move to my town but i want you to pay for your own housinga nd supplies. That would be all";
            }
           else if (stats.overallstat <= 2.99)
            {
                button1.text = "Back to Menu";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "From what ive heard you havent handled yourself very well around here and from the way you have handled yourself we wouldnt want someone like you around here so you shall be banished from my town, Be gone before i get the guards";
            }
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
           stats.activequestnum ++;
            stats.kindness += 0.1f;
            statChangeDisplay.DisplayStatChange("Kindness: +0.2", Color.green);

            stats.charisma += 0.2f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.2", Color.green);
            stats.determination += 0.2f;
            statChangeDisplay.DisplayStatChange("Determination: +0.2", Color.green);
        }
        else if (stats.activequestnum == 2)
        {

        }
        else if (stats.activequestnum == 3)
        {

        }
        else if (stats.activequestnum == 4)
        {
            stats.activequestnum++;
            stats.npc3 += 1;
            stats.kindness += 0.2f;
            statChangeDisplay.DisplayStatChange("Kindness: +0.2", Color.green);
            stats.charisma += 0.2f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.2", Color.green);

        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {
            stats.activequestnum++;
            stats.kindness += 0.1f;
            statChangeDisplay.DisplayStatChange("Kindness: +0.1", Color.green);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.1", Color.green);
            stats.determination += 0.2f;
            statChangeDisplay.DisplayStatChange("Determination: +0.2", Color.green);
        }
        else if (stats.activequestnum == 8)
        {

        }
        else if (stats.activequestnum == 9)
        {

        }
        else if (stats.activequestnum == 10)
        {
            stats.activequestnum++;
        }
        else if (stats.activequestnum == 11)
        {
            SceneManager.LoadScene(0);
        }
        else if (stats.activequestnum == 12)
        {

        }
    }

    public void buttontwopress()
    {
        if (stats.activequestnum == 1)
        {
            stats.activequestnum++;
            stats.activequestnum++;
            stats.kindness -= 0.1f;
            statChangeDisplay.DisplayStatChange("Kindess: -0.1", Color.red);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.1", Color.green);
            stats.determination -= 0.2f;
            statChangeDisplay.DisplayStatChange("Determination: -0.2", Color.red);
            stats.honesty += 0.1f;
            statChangeDisplay.DisplayStatChange("Honesty: +0.1", Color.green);
        }
        else if (stats.activequestnum == 2)
        {

        }
        else if (stats.activequestnum == 3)
        {

        }
        else if (stats.activequestnum == 4)
        {
            stats.activequestnum++;
            stats.npc3 -= 1;
            stats.kindness -= 0.4f;
            statChangeDisplay.DisplayStatChange("Kindness: -0.4", Color.red);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: +0.1", Color.green);
            stats.honesty += 0.2f;
            statChangeDisplay.DisplayStatChange("Honesty: +0.2", Color.green);
        }
        else if (stats.activequestnum == 5)
        {

        }
        else if (stats.activequestnum == 6)
        {

        }
        else if (stats.activequestnum == 7)
        {
            stats.activequestnum++;
            stats.kindness += 0.1f;
            statChangeDisplay.DisplayStatChange("Kindness: -0.2", Color.red);
            stats.charisma += 0.1f;
            statChangeDisplay.DisplayStatChange("Charisma: -0.3", Color.red);
            stats.determination += 0.2f;
            statChangeDisplay.DisplayStatChange("Determination: -0.4", Color.red);
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
            if(stats.charisma >= 0.8f)
            {
                stats.activequestnum++;
                inventory.coins += 20;
                stats.kindness += 0.1f;
                statChangeDisplay.DisplayStatChange("Kindess: +0.1", Color.green);
                stats.charisma += 0.2f;
                statChangeDisplay.DisplayStatChange("Charisma: +0.2", Color.green);
                stats.honesty += 0.3f;
                statChangeDisplay.DisplayStatChange("Honesty: +0.3", Color.green);
                stats.empathy -= 0.3f;
                statChangeDisplay.DisplayStatChange("Empathy: +0.2", Color.green);
            }
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
