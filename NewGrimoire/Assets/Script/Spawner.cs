using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _mobContainer = null;
    [SerializeField] private float _delay = 5f;

    [SerializeField] private Transform[] _spawnPos = null;
    [SerializeField] private GameObject[] _mob = null;


    private float _timeStamp = 0;


    void Start()
    {

    }


    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        _timeStamp += Time.deltaTime;
        if (_timeStamp >= _delay)
        {
            int mobIndex = Random.Range(0, _mob.Length);
            int spawnIndex = Random.Range(0, _spawnPos.Length);
            Instantiate(_mob[mobIndex], _spawnPos[spawnIndex].position, Quaternion.identity, _mobContainer);
            _timeStamp = 0;
        }

    }
}