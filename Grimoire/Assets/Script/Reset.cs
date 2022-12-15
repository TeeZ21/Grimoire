using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField = null;

    void Start()
    {

    }

    void Update()
    {

    }

    public void Empty()
    {
        _inputField.text = string.Empty;
    }
}
