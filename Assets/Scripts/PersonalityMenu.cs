using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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


    void Update()
    {
        openmenu();
        personalitysliders();

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



}
