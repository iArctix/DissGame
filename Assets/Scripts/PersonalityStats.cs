using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "New perosnality data", menuName = "personalitystats/stats")]
public class PersonalityStats : ScriptableObject
{
    //Personality Stats
    public float kindness = 0f;
    public float determination = 0f;
    public float honesty = 0f;
    public float empathy = 0f;
    public float charisma = 0f;

    //Relationship stats
    public float npc1 = 0f;
    public float npc2 = 0f;
    public float npc3 = 0f;

}
