using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    public static Script_PlayerController instance;
    //ĳ���Ϳ�����
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
    /// �����ε�ĥ��
    /// </summary>
    void HitEnemy()
    {

    }

    /// <summary>
    /// ������ȹ��
    /// </summary>
    void GetItem()
    {

    }

    /// <summary>
    /// �÷��̾��̵� 
    /// </summary>
    /// <param name="_distance"> �̵��Ÿ��׼ӵ�</param>
    /// <param name="_vector3">�̵�����</param>
    public void Move(float _distance, Vector3 _vector3)
    {
        m_isKeyLock = false;
        StartCoroutine(MoveCo(m_moveSpeed / _distance, transform.position + _vector3 * _distance));
    }

    //������ ������
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
