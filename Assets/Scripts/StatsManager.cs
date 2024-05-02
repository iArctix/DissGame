using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public PersonalityStats stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //looks after styats make sure within correct bounds
        if (stats.kindness > 1)
        {
            stats.kindness = 1;
        }
        else if (stats.kindness < 0)
        {
            stats.kindness = 0;
        }

        if (stats.determination > 1)
        {
            stats.determination = 1;
        }
        else if (stats.determination < 0)
        {
            stats.determination = 0;
        }

        if (stats.honesty > 1)
        {
            stats.honesty = 1;
        }
        else if (stats.honesty < 0)
        {
            stats.honesty = 0;
        }

        if (stats.empathy > 1)
        {
            stats.empathy = 1;
        }
        else if (stats.empathy < 0)
        {
            stats.empathy = 0;
        }

        if (stats.charisma > 1)
        {
            stats.charisma = 1;
        }
        else if (stats.charisma < 0)
        {
            stats.charisma = 0;
        }

        if(stats.npc1 < 1)
        {
            stats.npc1 = 1;
        }
        else if (stats.npc1 > 3)
        {
            stats.npc1 = 3;
        }

        if (stats.npc2 < 1)
        {
            stats.npc2 = 1;
        }
        else if (stats.npc2 > 3)
        {
            stats.npc2 = 3;
        }

        if (stats.npc3 < 1)
        {
            stats.npc3 = 1;
        }
        else if (stats.npc3 > 3)
        {
            stats.npc3 = 3;
        }
    }
}
