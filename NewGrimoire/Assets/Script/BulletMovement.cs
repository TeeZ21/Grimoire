using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Attributs
    [SerializeField] private int _speed = 20;
    [SerializeField] private bool _wrongType = false;
    public int _score = 0;

    public EBulletTypes _bulletTypes = EBulletTypes.FIRE;
    public GameObject _player = null;


    #endregion Attributs

    void Start()
    {

    }


    void Update()
    {

        if (_wrongType == false)
        {
            Moving();
        }
        else
        {
            Reverse();
        }
        DestroyObjectDelayed();
    }

    void Moving()
    {
        transform.position += transform.right * Time.deltaTime * _speed;
    }

    void Reverse()
    {
        transform.position -= transform.right * Time.deltaTime * _speed;
    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5);
    }

    void Scoring()
    {
        _score = _score + 10;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mob")
        {
            MobController mob = other.GetComponentInParent<MobController>();
            if(_bulletTypes == mob.MobTypes)
            {
                _wrongType = false;
                Scoring();
                Debug.Log(_score);
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
            }
            if(_bulletTypes != mob.MobTypes)
            {
                _wrongType = true;
                if (other.tag == "Player")
                {
                    Debug.Log(_player);
                    Destroy(_player);
                }
            }
        }
    }
}
