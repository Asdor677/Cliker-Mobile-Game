using Unity.VisualScripting;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public GameObject _EscMenu;
    public GameObject _StartMenu;
    public GameObject _LeftMenu;
    public GameObject _More;
    public GameObject _Pause;
    public GameObject _Paper;
    public GameObject _Setting;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _EscMenu.SetActive(!_EscMenu.activeSelf);
            _LeftMenu.SetActive(false);
            _Pause.SetActive(!_Pause.activeSelf);
            _More.SetActive(!_More.activeSelf);
            _Paper.SetActive(false);
            _Setting.SetActive(false);
        }
    }

    private void Start()
    {
        _StartMenu.SetActive(true);
    }
}
