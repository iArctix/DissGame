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
            questprompt.text = "Talk to the queen";
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
