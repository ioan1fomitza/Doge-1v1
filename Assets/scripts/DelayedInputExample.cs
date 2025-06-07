using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedInputExample : MonoBehaviour
{
    public float _delay = 10f;
    float _currentTime = 0f;
    private bool _hasPressedKey = false;

    // Update is called once per frame
    void Update()
    {
        if (_hasPressedKey == true)
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > _delay)
            {
                Destroy(gameObject); //sau alta functie pe care o doriti
                _hasPressedKey = false;
                _currentTime = 0f;
            }
        }
        if (_hasPressedKey == false)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                _hasPressedKey = true;
            }
        }
    }
}