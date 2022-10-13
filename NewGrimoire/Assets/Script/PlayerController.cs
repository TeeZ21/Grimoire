using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform[] _posCharacter = null;
    [SerializeField] private int _index = 1;
    #endregion Attributs

    void Start()
    {
        transform.position = _posCharacter[1].position;
    }

    void Update()
    {
        Moving();
    }
    private void Moving()
    {
        bool moveUp = Input.GetKeyDown(KeyCode.UpArrow);
        bool moveDown = Input.GetKeyDown(KeyCode.DownArrow);

        if(moveDown && _index < _posCharacter.Length)
        {
            _index++;
            transform.position = _posCharacter[_index].position;
        }
        
        if(moveUp && _index > 0)
        {
            _index--;
            transform.position = _posCharacter[_index].position;
        }
    }
}