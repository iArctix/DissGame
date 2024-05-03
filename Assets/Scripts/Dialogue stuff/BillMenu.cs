using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BillMenu : MonoBehaviour
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
            Dialogue.text = "Hey im Bill welcome to town i think the queen wants to talk";
        }
        else if (stats.activequestnum == 2)
        {
            button1.text = "Of course i would love to help";
            button2.text = "I guess i will for a price";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Hello could you please help im stuggling to make some money and would love some apples to sell ive fallen on hard times recently";
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh okay thats fine i guess i will manage as i always do";
            }
            else if (stats.applechocie == 2)
            {
                button1.text = "Here have the apples for free i know times are hard (-5 apples) ";
                button2.text = "I have the apples but i want some sort of payment in return (+ 20 coins)";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Wow how generous please hand them over when you can";
            }
        }
        else if (stats.activequestnum == 4)
        {
            if (stats.npc1 == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh its you, i think the queen wants to talk bye";
            }
            else if (stats.npc1 == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hello the queen is requesting you ";
            }
            else
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Oh hi friend thanks for the help the queen wants to talk. See you soon";
            }
        }
        else if (stats.activequestnum == 5) //Help BIll quest
        {
            button1.text = "Im sure i can help out my friend no worries";
            button2.text = "Thats a lot of work this better be worth my while";
            button3.text = "";
            button4.text = "";
            Dialogue.text = "Hello again so as you know im struggling at the moment and need want to get a home of my own now for that i need some wood so could you help fetch me some ";
        }
        else if (stats.activequestnum == 6)
        {
            button1.text = "Here i have the wood you need (-10 wood)";
            button2.text = "Im friends with the queen if i give you some she will cover the rest im sure (-7 wood) (Need to be friends with the queen";
            button3.text = "I cant be bothered to go gather heres some gold you can buy some instead (-30 gold)";
            button4.text = "Here but i want payment (-10 wood +20 gold)";
            Dialogue.text = "Hey i need 10 wood to be able to start my house";
        }
        else if (stats.activequestnum == 7)
        {
            if (stats.npc1 == 1)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Thanks for nothing anyway the queen wants to talk again ";
            }
            else if (stats.npc1 == 2)
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Appreciate your assistance you dont understand how hard its been. the queen wants you again i think";
            }
            else
            {
                button1.text = "";
                button2.text = "";
                button3.text = "";
                button4.text = "";
                Dialogue.text = "Friend you are honestly a life saver the queen wants to talk i heard";
            }
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
            stats.empathy += 0.2f;
            stats.kindness += 0.1f;
            stats.charisma += 0.1f;
            stats.npc1 += 1f;
            stats.npc2 -= 1f;
            stats.applechocie = 2;
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
               
            }
            else if (stats.applechocie == 2)
            {
                if (inventory.apples >= 5)
                {
                    stats.activequestnum += 1;
                    inventory.apples -= 5;

                    stats.kindness += 0.2f;
                    stats.empathy += 0.2f;
                    stats.honesty += 0.2f;
                }
            }
        }
        else if (stats.activequestnum == 4)
        {

        }
        else if (stats.activequestnum == 5)
        {
            stats.activequestnum++;
        }
        else if (stats.activequestnum == 6)
        {
            if (inventory.wood >= 10)
            {
                stats.activequestnum++;
                inventory.wood -= 10;
                stats.npc1 += 1;
                stats.determination += 0.2f;
                stats.kindness += 0.2f;

            }
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
            stats.empathy += 0.2f;
            stats.kindness -= 0.1f;
            stats.charisma -= 0.1f;
            stats.npc1 += 1f;
            stats.npc2 -= 1f;
            stats.applechocie = 2;
        }
        else if (stats.activequestnum == 3)
        {
            if (stats.applechocie == 1)
            {
                
            }
            else if (stats.applechocie == 2)
            {
                if (inventory.apples >= 5)
                {
                    stats.activequestnum += 1;
                    inventory.coins += 20;

                    stats.kindness -= 0.3f;
                    stats.empathy -= 0.3f;
                    stats.honesty += 0.2f;
                    stats.charisma += 0.1f;
                    stats.npc1 -= 1f;
                }
            }
        }
        else if (stats.activequestnum == 4)
        {
           

        }
        else if (stats.activequestnum == 5)
        {
            stats.activequestnum++;
        }
        else if (stats.activequestnum == 6)
        {
            if (inventory.wood >= 7 && stats.npc3 == 3)
            {
                stats.activequestnum++;
                inventory.wood -= 7;
                stats.npc1 += 1;
                stats.kindness += 0.1f;
                stats.charisma += 0.3f;

            }
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
            if(inventory.coins >= 30)
            {
                stats.activequestnum++; 
                inventory.coins -= 30;
                stats.determination -= 0.5f;
                stats.kindness -= 0.2f;
                stats.honesty += 0.1f;
                stats.npc1 -= 1;

                

            }
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
            if (inventory.wood >= 10)
            {
                stats.activequestnum++;
                inventory.coins += 20;
                inventory.wood -= 10;
                stats.determination -= 0.2f;
                stats.kindness -= 0.4f;
                stats.honesty += 0.2f;
                stats.empathy -= 0.4f;
                stats.npc1 -= 2;



            }
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
