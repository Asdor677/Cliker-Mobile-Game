using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject _enemys;
    Vector2 _pointPosition;
    private float _randomX;
    public static float _spawnDelay = 1.5f;
    private float _nextSpawn = 0.0f;
    public float _timeDestroy = 1.7f;
    public float _leftZone = -8;
    public float _rightZone = 8;

    void FixedUpdate()
    {
        if(Time.time > _nextSpawn)
        {
            _nextSpawn = Time.time + _spawnDelay;
            _randomX = Random.Range(_leftZone, _rightZone);
            _pointPosition = new Vector2(_randomX, transform.position.y);
            GameObject _Enemy = Instantiate(_enemys, _pointPosition, Quaternion.identity);
            Destroy(_Enemy, _timeDestroy);
        }
        
    }
}
