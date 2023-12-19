using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickKill: MonoBehaviour, IPointerClickHandler
{
    public int _HealfMax = 20;
    private Animator _anims;
    private float _ToClick;
    public GameObject _Boss;
    public GameObject _BossNew;

    //HP Bar system
    private float HP = 100f;
    public Image Bar;
    public TextMeshProUGUI _HPText;
    public float _Damage;

    private int _Pain;

    void Start()
    {
        _anims = GetComponent<Animator>();
        _HPText.text = _HealfMax.ToString($"{_HealfMax}");
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) { _anims.SetFloat("Pain", _Pain = 1); Debug.Log("Here 1"); }
        if (Input.GetMouseButtonDown(0)) { _anims.SetFloat("Pain", _Pain = 0); Debug.Log("Here 0"); }
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        do
        {
            Debug.Log($"Click, {_HealfMax}");
            _HealfMax--;
            _HPText.text = _HealfMax.ToString($"{_HealfMax}");
            HP -= _Damage; Bar.fillAmount = HP / 100;
            _anims.SetFloat("Pain", _Pain = 1); Debug.Log("Here 1");
            if ( _HealfMax == 0) { _Boss.SetActive(false); _BossNew.SetActive(true);}
        }
        while (_HealfMax == 0);
    }  
}