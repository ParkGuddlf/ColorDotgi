using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //옵션관리 게임시작 게임엔드 기록
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void LateUpdate()
    {
        if (Script_CharacterState.CurrentHp == 0)
            Debug.Log("게임오버");

    }
}
