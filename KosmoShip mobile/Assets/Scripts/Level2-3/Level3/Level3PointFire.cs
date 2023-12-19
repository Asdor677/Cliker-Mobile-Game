using System.Collections;
using UnityEngine;

public class Level3PointFire : MonoBehaviour
{
    public float _speed;
    public float _time;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right* _speed * Time.fixedDeltaTime);
        _time -= Time.deltaTime;
        if (_time <= 0) { Destroy(gameObject); }
    }
}
