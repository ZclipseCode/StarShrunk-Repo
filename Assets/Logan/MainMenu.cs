using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Ethan LvL1");
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void Controls()
    {
        SceneManager.LoadScene("Logan Tutorial");
    }
}
