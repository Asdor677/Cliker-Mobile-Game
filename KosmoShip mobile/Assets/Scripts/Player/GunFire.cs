using UnityEngine;

public class GunFire : MonoBehaviour
{
    public GameObject _bulet;
    public Transform _point;
    public Transform _point2;
    public Transform _point3;
    public float _startTime;
    public float _timeShot;

    public static bool point2 = false;
    public static bool point3 = false;

    private void FixedUpdate()
    {
        if (_timeShot <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(_bulet, _point.position, transform.rotation);
                _timeShot = _startTime;
            }
            if (Input.GetMouseButton(0) && point2 == true)
            {
                Instantiate(_bulet, _point2.position, transform.rotation);
                _timeShot = _startTime;
            }
            if (Input.GetMouseButton(0) && point3 == true)
            {
                Instantiate(_bulet, _point3.position, transform.rotation);
                _timeShot = _startTime;
            }
        }
        else { _timeShot -= Time.fixedDeltaTime; }
    }
    public void Activ1() { point2 = true; }
    public void Activ2() { point3  = true; }
    public void BuletSek() { _startTime = 0.1f; }
}
