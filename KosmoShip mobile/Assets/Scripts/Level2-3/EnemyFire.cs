using System.Collections;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject _bulet;
    public Transform _point;
    public float _startTime;
    public float _timeShot;

    private void FixedUpdate()
    {
        StartCoroutine(BuletSpawn());
    }

    private IEnumerator BuletSpawn()
    {
        yield return new WaitForSeconds(_timeShot);
        if (_timeShot <= 0)
        {
            Instantiate(_bulet, _point.position, transform.rotation);
            _timeShot = _startTime;
        }
        else { _timeShot -= Time.fixedDeltaTime; }
    }
}
