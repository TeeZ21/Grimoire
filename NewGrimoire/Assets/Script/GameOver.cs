using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("LVL_01");
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
