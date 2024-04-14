using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Gameone()
    {
        SceneManager.LoadScene(1);
    }
    public void Gametwo()
    {
        SceneManager.LoadScene(2);
    }
}
