using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "New perosnality data", menuName = "personalitystats/stats")]
public class PersonalityStats : ScriptableObject
{
    //Personality Stats 0-1
    public float kindness = 0.5f;
    public float determination = 0.5f;
    public float honesty = 0.5f;
    public float empathy = 0.5f;
    public float charisma = 0.5f;

    //Relationship stats level 1-3
    //bill
    public float npc1 = 2f;
    //fred
    public float npc2 = 2f;
    //maria
    public float npc3 = 2f;

    //Quest Number
    public int activequestnum = 1;

    //QUEST LIST
    /*    
     1- Talk to queen
    2- Help Bill of fred
    3- Gather or steal 5 apples
    4- donate the apples
    5- go back to the queen
    
     
     
     
     
     
     
     
     
     
     
     
     
     
     */

}
