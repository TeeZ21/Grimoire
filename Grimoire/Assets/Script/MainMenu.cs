using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject _mainMenu = null;
    public GameObject _controlsMenu = null;

    public void Play()
    {
        SceneManager.LoadScene("LVL_01");
        Time.timeScale = 1;
    }

    public void Controls()
    {
        _controlsMenu.SetActive(true);
        _mainMenu.SetActive(false);
    }

    public void Back()
    {
        _mainMenu.SetActive(true);
        _controlsMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
