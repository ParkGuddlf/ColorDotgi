using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_UiManager : MonoBehaviour
{

    [Header("최대체력 유아이")]
    public GameObject _heartMaxContainer;
    [Header("현제체력 유아이")]
    public GameObject _heartContainer;
    private float _fillValue;

    void Update()
    {
        CurrentHpUI();
    }
    //현제체력관리
    void CurrentHpUI()
    {
        _fillValue = (float)Script_CharacterState.CurrentHp;
        _fillValue = _fillValue / Script_CharacterState.MaxHp;
        _heartContainer.GetComponent<Image>().fillAmount = _fillValue;
    }
    void MaxHPUI()
    {
        _heartMaxContainer.GetComponent<Image>().fillAmount = Script_CharacterState.MaxHp / 12;
    }
}
