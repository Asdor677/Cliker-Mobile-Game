using System;
using TMPro;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI _coins;
    public static int _coinsInt;

    private void Update()
    {
        _coins.text = _coinsInt.ToString($"{_coinsInt}");
    }
    public void PlusButtonCoin()
    {
        _coinsInt++;
    }
}
