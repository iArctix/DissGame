using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "New Inventory Data", menuName = "Inventory stats/inventory")]
public class InventoryStats : ScriptableObject
{
    public int coins;
    public int apples;
    public int wood;
    public bool swordfound =false;

}
