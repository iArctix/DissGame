using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public PersonalityStats stats;
    public TextMeshProUGUI questprompt;

    // Start is called before the first frame update
    private void Start()
    {
        stats.activequestnum = 1;
    }
    // Update is called once per frame
    void Update()
    {
        QuestHelp();
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
            questprompt.text = "Help Bill with his problem, gather wood or pay him";
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
            questprompt.text = "Find Freds lost ";

        }
        else if (stats.activequestnum == 10)
        {
            questprompt.text = "";
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
