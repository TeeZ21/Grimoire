using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform _bulletContainer = null;
    [SerializeField] private Transform _weaponPoint = null;
    [SerializeField] private GameObject[] _bulletTypes;
    [SerializeField] private TMP_InputField _inputField = null;
    #endregion Attributs

    void Start()
    {
        
    }

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        /*bool fire = Input.GetKeyDown(KeyCode.F);
        bool water = Input.GetKeyDown(KeyCode.W);
        bool shock = Input.GetKeyDown(KeyCode.S);

        if (fire)
        {
            Instantiate(_bulletTypes[0], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (water)
        {
            Instantiate(_bulletTypes[1], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (shock)
        {
            Instantiate(_bulletTypes[2], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }*/
    }
    public void Shooting()
    {
        if(_inputField.text == "Fire")
        {
            Debug.Log("Fire");
            Instantiate(_bulletTypes[0], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if(_inputField.text == "Water")
        {
            Debug.Log("Water");
            Instantiate(_bulletTypes[1], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if(_inputField.text == "Shock")
        {
            Debug.Log("Shock");
            Instantiate(_bulletTypes[2], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
    }
}
