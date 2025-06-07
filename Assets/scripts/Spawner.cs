using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject _objectToSpawn;
    public Transform _spawnPoint;
    public float _delay = 10f;
    float _currentTime = 0f;

    void Update()
    {
        // Manual spawn with M key
        if (Input.GetKeyDown(KeyCode.M))
        {
            Instantiate(_objectToSpawn, _spawnPoint.position, _spawnPoint.rotation);
        }

        // Automatic spawn every _delay seconds
        _currentTime += Time.deltaTime;

        if (_currentTime >= _delay)
        {
            Instantiate(_objectToSpawn, _spawnPoint.position, _spawnPoint.rotation);
            _currentTime = 0f;
        }
    }
}