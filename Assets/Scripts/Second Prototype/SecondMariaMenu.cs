using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondMariaMenu : MonoBehaviour
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
            button1.text = "Okay i happily will thankyou for the welcome";
            button2.text = "";
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
        else if (stats.activequestnum == 3)
        {
            button1.text = "";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Come talk to me later after you have finished your task";
        }
        else if (stats.activequestnum == 4)
        {
            button1.text = "Okay i will happily go talk i want to live here";
            button2.text = "";
            button3.text = "";
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
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Thanks for helping him out thats kind of you. Anyway next i want you to help out fred find him in town near me ";
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
            Dialogue.text = "Complete freds task and then return to me";
        }
        else if (stats.activequestnum == 10)
        {
            button1.text = "Yes queen im ready";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Ok so you ahve completed your tasks and i have made up my mind about you. Would you like to hear if i deem you worthy of living here?";
        }
        else if (stats.activequestnum == 11)
        {
            button1.text = "Back To Menu";
            button2.text = "";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "After you have been through the town meeting my subjects ive heard nothing but good things of the way you handle yourself .I would glady allow you to live here and even better i will allow you to live in one of our already built houses to show my gratitude";
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
            stats.activequestnum++;
          
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