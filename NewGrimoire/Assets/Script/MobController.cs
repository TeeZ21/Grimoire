using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    #region Attributs
    [SerializeField] private float _speed = 10f;
    [SerializeField] public ETypes _mobTypes = ETypes.FIRE;
    #endregion Attributs

    public ETypes MobTypes 
    {
        get
        {
            return _mobTypes;
        }
    }

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
