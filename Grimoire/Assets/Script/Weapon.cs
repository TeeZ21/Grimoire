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
    [SerializeField] private AudioSource _fireSound;
    [SerializeField] private AudioSource _waterSound;
    [SerializeField] private AudioSource _windSound;


    #endregion Attributs

    void Start()
    {
        
    }

    void Update()
    {

    }

    public void Shooting()
    {
        if(_inputField.text == "Fire")
        {
            Debug.Log("Fire");
            Instantiate(_bulletTypes[0], _weaponPoint.position, Quaternion.identity, _bulletContainer);
            _fireSound.Play();
        }
        if(_inputField.text == "Water")
        {
            Debug.Log("Water");
            Instantiate(_bulletTypes[1], _weaponPoint.position, Quaternion.identity, _bulletContainer);
            _waterSound.Play();
        }
        if(_inputField.text == "Wind")
        {
            Debug.Log("Wind");
            Instantiate(_bulletTypes[2], _weaponPoint.position, Quaternion.identity, _bulletContainer);
            _windSound.Play();
        }
    }
}
