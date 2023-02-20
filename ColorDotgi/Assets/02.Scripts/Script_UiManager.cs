using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_UiManager : MonoBehaviour
{

    [Header("�ִ�ü�� ������")]
    public GameObject _heartMaxContainer;
    [Header("����ü�� ������")]
    public GameObject _heartContainer;
    private float _fillValue;

    void Update()
    {
        CurrentHpUI();
    }
    //����ü�°���
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
