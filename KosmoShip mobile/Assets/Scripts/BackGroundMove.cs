using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float _speed;
    private Vector2 _moveVector;
    public Transform _mainPoint;
    public float _distance;
    bool _moveRight;

    private void FixedUpdate()
    {
        if (transform.position.x > _mainPoint.position.x + _distance) { _moveRight = false; }
        else if (transform.position.x < _mainPoint.position.x - _distance) { _moveRight = true; }

        if (_moveRight) { transform.position = new Vector2(transform.position.x + _speed * Time.fixedDeltaTime, transform.position.y); }
        else { transform.position = new Vector2(transform.position.x - _speed * Time.fixedDeltaTime, transform.position.y); }
    }

}
