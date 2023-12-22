using UnityEngine;
using UnityEngine.EventSystems;

public class CenikSystem : MonoBehaviour, IPointerClickHandler
{
    public int _cena;
    public GameObject _tovar;
    public GameObject _tovarInventory;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(CoinSystem._coinsInt >= _cena) { _tovar.SetActive(false); CoinSystem._coinsInt = CoinSystem._coinsInt - _cena; _tovarInventory.SetActive(true); }
    }
}
