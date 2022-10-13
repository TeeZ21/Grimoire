using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform[] _posCharacter = null;

    #endregion Attributs

    void Start()
    {

    }

    void Update()
    {
        Moving();
    }
    private void Moving()
    {
        bool moveUp = Input.GetKeyDown(KeyCode.UpArrow);
        bool moveDown = Input.GetKeyDown(KeyCode.DownArrow);

        int index = 0;

        if(moveUp)
        {
            for (int i = 0; i < _posCharacter.Length; i++)
            {
                transform.position = _posCharacter[index].position;
            }
        }

    }


}
