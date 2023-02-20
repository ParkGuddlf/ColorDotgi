using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    public static Script_PlayerController instance;
    //캐릭터움직임
    float m_moveSpeed;
    public bool m_isKeyLock = true;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        m_moveSpeed = Script_CharacterState.MoveSpeed;
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Script_CharacterState.CurrentHp -= 1;
        }
    }
    /// <summary>
    /// 적과부디칠때
    /// </summary>
    void HitEnemy()
    {

    }

    /// <summary>
    /// 아이템획득
    /// </summary>
    void GetItem()
    {

    }

    /// <summary>
    /// 플레이어이동 
    /// </summary>
    /// <param name="_distance"> 이동거리및속도</param>
    /// <param name="_vector3">이동방향</param>
    public void Move(float _distance, Vector3 _vector3)
    {
        m_isKeyLock = false;
        StartCoroutine(MoveCo(m_moveSpeed / _distance, transform.position + _vector3 * _distance));
    }

    //끝에서 느려짐
    IEnumerator MoveCo(float moveTime, Vector3 movePoint)
    {
        var currentPos = transform.position;
        var time = 0f;
        while (time < 1)
        {
            time += Time.deltaTime / moveTime;
            transform.position = Vector3.Slerp(currentPos, movePoint, time);
            yield return null;
        }
        yield return new WaitForEndOfFrame();
        m_isKeyLock = true;

    }
}
