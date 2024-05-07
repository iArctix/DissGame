using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public PersonalityStats stats;
    public TextMeshProUGUI questprompt;
    public InventoryStats inventory;

    // Start is called before the first frame update
    private void Start()
    {
        stats.charisma = 0.4f;
        stats.kindness = 0.4f;
        stats.honesty = 0.4f;
        stats.determination = 0.4f;
        stats.empathy = 0.4f;
        stats.activequestnum = 1;
        stats.npc1 = 2;
        stats.npc2 = 2;
        stats.npc3 = 2;

        inventory.apples = 0;
        inventory.wood = 0;
        inventory.coins = 0;
        stats.activequestnum = 1;
    }
    // Update is called once per frame
    void Update()
    {
        QuestHelp();
        stats.overallstat = stats.kindness + stats.charisma + stats.determination + stats.empathy + stats.honesty;
    }

    void QuestHelp()
    {
        if(stats.activequestnum == 1)
        {
            questprompt.text = "Talk to the queen";
        }
        else if(stats.activequestnum == 2)
        {
            questprompt.text = "Help either the peasant or the villager";
        }
        else if(stats.activequestnum == 3)
        {
            questprompt.text = "Gather or steal 5 apples and give them ";
        }
        else if (stats.activequestnum == 4)
        {
            questprompt.text = "Talk to the queen";
        }
        else if (stats.activequestnum == 5)
        {
            questprompt.text = "Talk to bill at the market";
        }
        else if (stats.activequestnum == 6)
        {
            questprompt.text = "Help Bill with his problem, gather wood or pay him (gather fallen logs or stumps)";
        }
        else if (stats.activequestnum == 7)
        {
            questprompt.text = "Return back to the queen";
        }
        else if (stats.activequestnum == 8)
        {
            questprompt.text = "Talk to Fred in the town";
        }
        else if (stats.activequestnum == 9)
        {
            questprompt.text = "Find Freds lost sword";

        }
        else if (stats.activequestnum == 10)
        {
            questprompt.text = "Talk to the Queen";
        }
        else if (stats.activequestnum == 11)
        {
            questprompt.text = "";
        }
        else if (stats.activequestnum == 12)
        {

        }


    }
}
