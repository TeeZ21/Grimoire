using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private float _speed = 10f;
    #endregion Attributs

    void Start()
    {

    }

    void Update()
    {
        Moving();
    }

    void Moving()
    {
        transform.position = transform.position + transform.right * _speed * Time.deltaTime;
    }
}
