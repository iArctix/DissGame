using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonalityMenu : MonoBehaviour
{
    public GameObject gameplayui;
    public GameObject personalityui;
    public GameObject PlayerCamera;


    void Update()
    {
        openmenu();

    }

    void openmenu()
    {
        if (Input.GetKeyDown(KeyCode.M) && !personalityui.activeSelf)
        {
            personalityui.SetActive(true);
            gameplayui.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.M) && personalityui.activeSelf)
        {
            personalityui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;
        }

    }


}
