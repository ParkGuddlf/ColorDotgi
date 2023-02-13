using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CharacterState : MonoBehaviour
{
    public static Script_CharacterState instance;
        private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private static int curretHp = 3;
    private static int maxHp = 6;
    private static float moveSpeed = 0.5f;

    public static int CurrentHp { get => curretHp; set => curretHp = value; }
    public static int MaxHp { get => maxHp; set => maxHp = value; }
    public static float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }

    //체력은 아이작형식 하트 반하트

    void Start()
    {
        Debug.Log(CurrentHp);
        Debug.Log(MaxHp);
    }
}
