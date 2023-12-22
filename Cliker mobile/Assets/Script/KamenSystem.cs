using UnityEngine;

public class KamenSystem : MonoBehaviour
{
    public float _time = 15;
    public GameObject _rock1;
    public GameObject _rock2;
    public GameObject _rock3;
    public GameObject _rock4;
    public GameObject _rock5;

    private void FixedUpdate()
    {
        _time -= Time.deltaTime;
        if (_time <= 0) 
        { 
            _rock1.SetActive(true);
            _rock2.SetActive(true);
            _rock3.SetActive(true);
            _rock4.SetActive(true);
            _rock5.SetActive(true);
            _time = 15; 
        }
    }
}
