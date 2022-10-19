using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform _bulletContainer = null;
    [SerializeField] private Transform _weaponPoint = null;
    [SerializeField] private GameObject _bulletFire ;
    [SerializeField] private GameObject _bulletWater;
    [SerializeField] private GameObject _bulletShock;
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
        bool fire = Input.GetKeyDown(KeyCode.F);
        bool water = Input.GetKeyDown(KeyCode.W);
        bool shock = Input.GetKeyDown(KeyCode.S);

        if (fire)
        {
            Instantiate(_bulletFire, _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (water)
        {
            Instantiate(_bulletWater, _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (shock)
        {
            Instantiate(_bulletShock, _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
    }
}
