using UnityEngine;

public class ScoreTabLevel2 : MonoBehaviour
{
    public static float _nextLevel;
    public GameObject _music;

    void Start() { _music.SetActive(true); _music.SetActive(false); }

    private void FixedUpdate()
    {
        if (_nextLevel == 12) { SpawnPoints._spawnDelay = 1.4f; }
        else if (_nextLevel == 26) { SpawnPoints._spawnDelay = 1.3f; }
        else if (_nextLevel == 33) { _music.SetActive(true); }
        else if (_nextLevel == 39) { SpawnPoints._spawnDelay = 1.2f; }
        else if (_nextLevel == 62) { SpawnPoints._spawnDelay = 1.1f; }
        else if (_nextLevel == 85) { SpawnPoints._spawnDelay = 1.0f; }
        else if (_nextLevel == 95) { SpawnPoints._spawnDelay = 0.8f; }
        else if (_nextLevel == 117) { SpawnPoints._spawnDelay = 0.6f; }
    }
}
