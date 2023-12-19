using UnityEngine;
using UnityEngine.SceneManagement;

public class BuletTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bulet")){ScoreTab._nextLevel += 1;ScoreTabLevel2._nextLevel += 1; Destroy(gameObject);}
        if (other.gameObject.CompareTag("DeathZone")){ SceneManager.LoadScene(0); Destroy(gameObject);}
    }
}
