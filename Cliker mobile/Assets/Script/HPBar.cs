using System;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{

    private float HP = 100f;
    public Image Bar;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) { HP -= 5; Bar.fillAmount = HP / 100; }
    }
}
