using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector2 _direction;
    public void SetDirection(Vector2 Direction)
    {
        _direction = Direction;
    }
    private void Update()
    {
        if (_direction.magnitude > 0)
        {
            var deltaSpeed = _direction * _speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + deltaSpeed.x, transform.position.y + deltaSpeed.y, transform.position.z);
        }

    }
    public void SaySomething()
    {
        Debug.Log("SaySomething!");
    }
}
