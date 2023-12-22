using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class WheellLogic : MonoBehaviour, IPointerClickHandler
{
    public float _time;
    public GameObject _wheel;

    private void FixedUpdate()
    {
        _time -= Time.deltaTime;
    }

    public void OnPointerClick(PointerEventData eventData)
    {   
        if (_time <= 0) 
        {
            Debug.Log("Whell");         
            _time = 10f;
            int rand = Random.Range(1, 5);
            if (rand == 1) { StartCoroutine(V1());}
            if (rand == 2) { StartCoroutine(V2()); }
            if (rand == 3) { StartCoroutine(V3()); }
            if (rand == 4) { StartCoroutine(V4()); }
        }
    }

    private IEnumerator V1()
    {
        _wheel.transform.Rotate(0, 0, 15);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 15);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 15);
        yield return new WaitForSeconds(2f);
        _wheel.transform.Rotate(0, 0, -45);
        CoinSystem._coinsInt = CoinSystem._coinsInt + 1;
    }
    private IEnumerator V2()
    {
        _wheel.transform.Rotate(0, 0, 45);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 45);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 45);
        yield return new WaitForSeconds(2f);
        _wheel.transform.Rotate(0, 0, -135);
        CoinSystem._coinsInt = CoinSystem._coinsInt + 2;
    }
    private IEnumerator V3()
    {
        _wheel.transform.Rotate(0, 0, 75);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 75);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 75);
        yield return new WaitForSeconds(2f);
        _wheel.transform.Rotate(0, 0, -225);
        CoinSystem._coinsInt = CoinSystem._coinsInt + 3;
    }
    private IEnumerator V4()
    {
        _wheel.transform.Rotate(0, 0, 105);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 105);
        yield return new WaitForSeconds(0.1f);
        _wheel.transform.Rotate(0, 0, 105);
        yield return new WaitForSeconds(2f);
        _wheel.transform.Rotate(0, 0, -315);
        CoinSystem._coinsInt = CoinSystem._coinsInt + 4;
    }
}
