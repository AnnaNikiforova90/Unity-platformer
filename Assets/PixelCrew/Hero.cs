using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _direction;
    public void SetDirection(float Direction)
    {
        _direction = Direction;
    }
    private void Update()
    {
        if (_direction != 0)
        {
            var deltaSpeed = _direction * _speed * Time.deltaTime;
            var newXPosition = transform.position.x + deltaSpeed;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        }

    }
    public void SaySomething()
    {
        Debug.Log("SaySomething!");
    }
}
