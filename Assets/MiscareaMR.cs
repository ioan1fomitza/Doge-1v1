using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscareaMR : MonoBehaviour
{
    public float _speed = 7.5f;
    public Rigidbody2D _rigidbody;
    public KeyCode _upKey = KeyCode.W;
    public KeyCode _downKey = KeyCode.S;
    public KeyCode _leftKey = KeyCode.A;
    public KeyCode _rightKey = KeyCode.D;
    float _distance;
    Vector2 _direction = new Vector2(0, 0);

    void Update()
    {
        //read inputs here
        _direction = Vector2.zero;

        if (Input.GetKey(_upKey))
        {
            _direction.y += 1;
        }
        if (Input.GetKey(_downKey))
        {
            _direction.y -= 1;
        }
        if (Input.GetKey(_leftKey))
        {
            _direction.x -= 1;
        }
        if (Input.GetKey(_rightKey))
        {
            _direction.x += 1;
        }

    }

    private void FixedUpdate()
    {
        //move the player here if we received inputs
        if (_direction.magnitude != 0)
        {
            _distance = _speed * Time.fixedDeltaTime;
            _rigidbody.velocity = _direction * _speed;
        }
    }
}
