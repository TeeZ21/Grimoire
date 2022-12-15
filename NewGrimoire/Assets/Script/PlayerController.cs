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

    public int Score
    {
        get
        {
            return _score;
        }
    }
    #endregion Attributs

    void Start()
    {
        transform.position = _posCharacter[1].position;
        _inputField.ActivateInputField();
    }

    void Update()
    {

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