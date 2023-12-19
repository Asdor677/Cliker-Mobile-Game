using UnityEngine;
using UnityEngine.EventSystems;

public class ShowPaper : MonoBehaviour
{
    public GameObject _paperShow;
    public void OnPointerClick(PointerEventData eventData)
    {
        _paperShow.SetActive(true);
    }

    void Update()
    {
        if (_paperShow == true && Input.GetMouseButton(1)) { _paperShow.SetActive(false); }
    }
}
