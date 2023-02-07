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

    public static int CurrentHp { get => curretHp; set => curretHp = value; }
    public static int MaxHp { get => maxHp; set => maxHp = value; }

    //체력은 아이작형식 하트 반하트

    void Start()
    {
        Debug.Log(CurrentHp);
        Debug.Log(MaxHp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
