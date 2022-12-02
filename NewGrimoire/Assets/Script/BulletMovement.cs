using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    #region Attributs
    [SerializeField] private int _speed = 20;
    [SerializeField] public int _score;
    [SerializeField] public EBulletTypes _bulletTypes = EBulletTypes.FIRE;
    #endregion Attributs

    void Start()
    {

    }


    void Update()
    {
        Moving();
        DestroyObjectDelayed();

    }

    void Moving()
    {
        transform.position += transform.right * Time.deltaTime * _speed;
    }

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 5);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Mob")
        {
            MobController mob = other.GetComponentInParent<MobController>();
            if(_bulletTypes == mob.MobTypes)
            {
                _score ++;
                Debug.Log(_score);
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
