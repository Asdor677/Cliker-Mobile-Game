using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float _speed;
    private Vector2 _moveVector;
    public Transform _MainPoint;
    public float _DistancePatrol;
    bool _MoveRight;

    private void Update()
    {
        PlatforMoveS();
    }

    void PlatforMoveS()
    {
        if (transform.position.x > _MainPoint.position.x + _DistancePatrol) { _MoveRight = false; }
        else if (transform.position.x < _MainPoint.position.x - _DistancePatrol) { _MoveRight = true; }

        if (_MoveRight) { transform.position = new Vector2(transform.position.x + _speed * Time.deltaTime, transform.position.y); }
        else { transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y); }
    }
}
