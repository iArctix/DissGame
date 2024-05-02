using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PersonalityMenu : MonoBehaviour
{
    //Menu stuff
    public GameObject gameplayui;
    public GameObject personalityui;
    public GameObject PlayerCamera;
    // Personality data
    public PersonalityStats stats;

    //sliders
    public Slider kindnessslider;
    public Image kindnessfillImage;
    public Slider empathyslider;
    public Image empathyfillImage;
    public Slider honestyslider;
    public Image honestyfillImage;
    public Slider determinationslider;
    public Image determinationfillImage;
    public Slider charismaslider;
    public Image charismafillImage;

    //npcs
    public Image billimage;
    public Image fredimage;
    public Image mariaimage;

    public TextMeshProUGUI billtext;
    public TextMeshProUGUI fredtext;
    public TextMeshProUGUI mariatext;


    void Update()
    {
        openmenu();
        personalitysliders();
        relationships();

    }

    void openmenu()
    {
        if (Input.GetKeyDown(KeyCode.M) && !personalityui.activeSelf)
        {
            personalityui.SetActive(true);
            gameplayui.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;
            personalitysliders();

        }
        else if (Input.GetKeyDown(KeyCode.M) && personalityui.activeSelf)
        {
            personalityui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;
            personalitysliders();
        }

    }


    void personalitysliders()
    {


        kindnessslider.value = stats.kindness;
        float kindnessvalue = stats.kindness;
        Color kindnessfillColor = Color.Lerp(Color.red, Color.green, kindnessvalue);
        kindnessfillImage.color = kindnessfillColor;

        empathyslider.value = stats.empathy;
        float empathyvalue = stats.empathy;
        Color empathyfillColor = Color.Lerp(Color.red, Color.green, empathyvalue);
        empathyfillImage.color = empathyfillColor;

        honestyslider.value = stats.honesty;
        float honestyvalue = stats.honesty;
        Color honestyfillColor = Color.Lerp(Color.red, Color.green, honestyvalue);
        honestyfillImage.color = honestyfillColor;

        determinationslider.value = stats.determination;
        float determinationvalue = stats.determination;
        Color determinationfillColor = Color.Lerp(Color.red, Color.green, determinationvalue);
        determinationfillImage.color = determinationfillColor;

        charismaslider.value = stats.charisma;
        float charismavalue = stats.charisma;
        Color charismafillColor = Color.Lerp(Color.red, Color.green, charismavalue);
        charismafillImage.color = charismafillColor;
    }
    void relationships()
    {
        //Bill relationship
        if (stats.npc1 == 1)
        {
            billimage.color = Color.red;
            billtext.text = "Enemy";
            billtext.color = Color.red;
        }
        else if (stats.npc1 == 2)
        {
            billimage.color = Color.yellow;
            billtext.text = "Neutral";
            billtext.color = Color.yellow;
        }
        else if (stats.npc1 == 3)
        {
            billimage.color = Color.green;
            billtext.text = "Friend";
            billtext.color = Color.green;
        }

        //Fred relationship
        if (stats.npc2 == 1)
        {
            fredimage.color = Color.red;
            fredtext.text = "Enemy";
            fredtext.color = Color.red;
        }
        else if (stats.npc2 == 2)
        {
            fredimage.color = Color.yellow;
            fredtext.text = "Neutral";
            fredtext.color = Color.yellow;
        }
        else if (stats.npc2 == 3)
        {
            fredimage.color = Color.green;
            fredtext.text = "Friend";
            fredtext.color = Color.green;
        }

        //Maria relationship
        if (stats.npc3 == 1)
        {
            mariaimage.color = Color.red;
            mariatext.text = "Enemy";
            mariatext.color = Color.red;
        }
        else if (stats.npc3 == 2)
        {
            mariaimage.color = Color.yellow;
            mariatext.text = "Neutral";
            mariatext.color = Color.yellow;
        }
        else if (stats.npc3 == 3)
        {
            mariaimage.color = Color.green;
            mariatext.text = "Friend";
            mariatext.color = Color.green;
        }

    }
}
