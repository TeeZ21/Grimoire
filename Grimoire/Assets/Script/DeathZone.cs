using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject _gameOver = null;
    [SerializeField] private GameObject _panelField = null;
    [SerializeField] private GameObject _image = null;

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
            _image.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true;


        }
    }
}
