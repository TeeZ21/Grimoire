using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    #region Attributs
    [SerializeField] private Transform _bulletContainer = null;
    [SerializeField] private Transform _weaponPoint = null;
    [SerializeField] private GameObject[] _bulletTypes;
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
            Instantiate(_bulletTypes[0], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (water)
        {
            Instantiate(_bulletTypes[1], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
        if (shock)
        {
            Instantiate(_bulletTypes[2], _weaponPoint.position, Quaternion.identity, _bulletContainer);
        }
    }
}
