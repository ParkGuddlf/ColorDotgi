using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�ɼǰ��� ���ӽ��� ���ӿ��� ���
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void LateUpdate()
    {
        if (Script_CharacterState.CurrentHp == 0)
            Debug.Log("���ӿ���");

    }
}
