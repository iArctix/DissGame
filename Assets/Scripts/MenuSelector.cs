using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelector : MonoBehaviour
{
    public GameObject gameplayui;
    public GameObject menuui;
    public GameObject PlayerCamera;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !menuui.activeSelf)
        {
            menuui.SetActive(true);
            gameplayui.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.P) && menuui.activeSelf)
        {
            menuui.SetActive(false);
            gameplayui.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            PlayerCamera.GetComponent<CameraRotation>().enabled = true;
        }

        else if (Input.GetKeyDown(KeyCode.L) && menuui.activeSelf)
        {
            Cursor.lockState = CursorLockMode.Confined;
            PlayerCamera.GetComponent<CameraRotation>().enabled = false;
            SceneManager.LoadScene(0);
        }

    }



    
}

