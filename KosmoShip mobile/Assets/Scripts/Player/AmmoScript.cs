using Unity.VisualScripting;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    public float _speed;
    public float _time;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * _speed * Time.fixedDeltaTime);
        _time -= Time.deltaTime;
        if ( _time <= 0) { Destroy(gameObject);}
    }
    public void Distance() { _speed = 11; }
}
