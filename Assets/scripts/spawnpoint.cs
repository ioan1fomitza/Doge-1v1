using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    public GameObject _objectToSpawn;
    public Transform[] _spawnPoints;
    public float _delay = 8f;
    private float _currentTime = 0f;

    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _delay)
        {
            int index = Random.Range(0, _spawnPoints.Length);
            Transform chosenPoint = _spawnPoints[index];

            Instantiate(_objectToSpawn, chosenPoint.position, chosenPoint.rotation);

            _currentTime = 0f;
        }
    }
}

