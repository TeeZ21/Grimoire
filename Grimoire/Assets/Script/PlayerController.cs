using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform[] _posCharacter = null;
    [SerializeField] private int _index;
    [SerializeField] private  TMP_InputField _inputField = null;
    [SerializeField] private int _score;
    [SerializeField] private GameObject _pauseMenu = null;
    #endregion Attributs

    public int Score
    {
        get
        {
            return _score;
        }
    }


    void Start()
    {
        transform.position = _posCharacter[1].position;
        _inputField.ActivateInputField();

        _pauseMenu.SetActive(false);
        Cursor.visible = false;
    }

    void Update()
    {
        PauseMenu();
    }

    private void PauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _pauseMenu.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void Moving()
    {

        if(_inputField.text == "Up")
        {
            if(_index < _posCharacter.Length)
            {
                _index++;
                transform.position = _posCharacter[_index].position;
            }
        }
        if(_inputField.text == "Down")
        {
            if(_index > 0)
            {
                _index--;
                transform.position = _posCharacter[_index].position;
            }
        }
        _inputField.ActivateInputField();        
    }
}