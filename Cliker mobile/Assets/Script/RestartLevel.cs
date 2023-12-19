using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void SceneLoad(int numScene)
    {
        SceneManager.LoadScene(numScene);
        Debug.Log("Click");
    }
}
