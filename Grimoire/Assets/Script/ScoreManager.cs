using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int _score;
    public int Score => _score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Scoring(int score)
    {
        score += 10;
        Debug.Log(score);
    }
}
