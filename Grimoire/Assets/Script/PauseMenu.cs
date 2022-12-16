using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    #region Attributs
    [SerializeField] private GameObject _pauseMenu = null;
    #endregion Attributs

    void Start()
    {

    }

    void Update()
    {

    }

    public void Resume()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
