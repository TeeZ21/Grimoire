using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private float _speed = 10f;
    private Transform _target = null;
    #endregion Attributs

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 direction = _target.position - transform.position;
        transform.position += direction.normalized * _speed * Time.deltaTime;   
    }
}
