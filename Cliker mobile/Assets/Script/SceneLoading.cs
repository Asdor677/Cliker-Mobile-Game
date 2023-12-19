using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public void SceneLoad(int numScene)
    {
        SceneManager.LoadScene(numScene);
        Debug.Log("Click");
    }
}
