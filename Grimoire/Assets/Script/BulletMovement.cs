using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BulletMovement : MonoBehaviour
{
    #region Attributs
    [SerializeField] private int _speed = 20;
    [SerializeField] private bool _wrongType = false;
    [SerializeField] private AudioSource _hitSound;

    [SerializeField] private EBulletTypes _bulletTypes = EBulletTypes.FIRE;
    [SerializeField] private GameObject _player = null;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mob")
        {
            MobController mob = other.GetComponentInParent<MobController>();

            if (_bulletTypes == mob.MobTypes)
            {
                _wrongType = false;
                _hitSound.Play();
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
            }
            if (_bulletTypes != mob.MobTypes)
            {
                _wrongType = true;
                Debug.Log(_wrongType);
                _player.SetActive(false);

                if (other.tag == "Player")
                {
                    Debug.Log(_player);
                    Destroy(_player);
                }
            }

        }

        
       
    }
}
