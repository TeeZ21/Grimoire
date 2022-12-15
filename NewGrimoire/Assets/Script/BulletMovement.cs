using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BulletMovement : MonoBehaviour
{
    #region Attributs
    [SerializeField] private int _speed = 20;
    [SerializeField] private bool _wrongType = false;
    [SerializeField] private TextMeshProUGUI _scoreText = null;

    public int _score = 0;

    public EBulletTypes _bulletTypes = EBulletTypes.FIRE;
    public GameObject _player = null;


    #endregion Attributs

    void Start()
    {
        _score = 0;
        _scoreText.text = "Score : " + _score;
        Scoring(0);
    }

    void Scoring(int scoreToAdd)
    {
        _score += scoreToAdd;
        _scoreText.text = "Score : " + _score;
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

    void Scorring()
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
                Scoring(10);
                //Scoring();
                Debug.Log(_score);
                Destroy(other.transform.parent.gameObject);
                Destroy(gameObject);
            }
            if(_bulletTypes != mob.MobTypes)
            {
                _wrongType = true;
                Debug.Log(_wrongType);

                if (other.tag == "Player")
                {
                    Debug.Log(_player);
                    Destroy(_player);
                }
            }
        }
    }
}
