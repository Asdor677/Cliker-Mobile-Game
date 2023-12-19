using UnityEngine;

public class ShowHide : MonoBehaviour
{
   public GameObject _hidePrefab;

    public void ShowHideS()
    {
        _hidePrefab.SetActive(!_hidePrefab.activeSelf);
    }
}
