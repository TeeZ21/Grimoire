using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject _gameOver = null;
    public GameObject _panelField = null;

    void Start()
    {
        _gameOver.SetActive(false);
        Cursor.visible = false;

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Mob")
        {
            _gameOver.SetActive(true);
            _panelField.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true;


        }
    }
}
