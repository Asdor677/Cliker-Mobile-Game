using UnityEngine;

public class ScoreTab : MonoBehaviour
{
    public static float _nextLevel;
    public GameObject _music;
    public GameObject _oldPoint1;
    public GameObject _newPoint2;
    public GameObject _nextPoint3;
    public GameObject _prevPoint4;
    public GameObject _endPoint5;
    public GameObject _Hard;

    void Start() { _music.SetActive(true); _music.SetActive(false);}

    private void FixedUpdate()
    {
        if (_nextLevel == 3) { SpawnPoints._spawnDelay = 1.4f; }
        else if (_nextLevel == 6) { SpawnPoints._spawnDelay = 1.3f; }
        else if (_nextLevel == 9) { SpawnPoints._spawnDelay = 1.2f; }
        else if (_nextLevel == 12) { SpawnPoints._spawnDelay = 1.1f; }
        else if (_nextLevel == 15) { SpawnPoints._spawnDelay = 1.0f; }
        else if (_nextLevel == 18) { SpawnPoints._spawnDelay = 0.8f; }
        else if (_nextLevel == 21) { SpawnPoints._spawnDelay = 0.6f; }
        else if (_nextLevel == 24) { SpawnPoints._spawnDelay = 0.3f; }
        else if (_nextLevel == 30) { SpawnPoints._spawnDelay = 0.1f; }
        else if (_nextLevel == 40) { _music.SetActive(true); }
        else if ( _nextLevel == 150) { SpawnPoints._spawnDelay = 0.05f; _oldPoint1.SetActive(false); _newPoint2.SetActive(true); }
        else if ( (_nextLevel == 350)) { _newPoint2.SetActive(false); _nextPoint3.SetActive(true); }
        else if ((_nextLevel == 650)){SpawnPoints._spawnDelay = 0.01f;_nextPoint3.SetActive(false);_prevPoint4.SetActive(true);}
        else if ((_nextLevel == 955)) { _prevPoint4.SetActive(false); _endPoint5.SetActive(true);}
        else if ((_nextLevel == 1300)) { _Hard.SetActive(true); }
    }
}
