using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    [SerializeField] float m_moveSpeed;
    [SerializeField] bool m_isKeyLock;

    void Update()
    {
        if (m_isKeyLock)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
                Move(m_moveSpeed, Vector2.up);
            if (Input.GetKeyDown(KeyCode.DownArrow))
                Move(m_moveSpeed, Vector2.down); 
            if (Input.GetKeyDown(KeyCode.RightArrow))
                Move(m_moveSpeed, Vector2.right); 
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                Move(m_moveSpeed, Vector2.left);
        }

    }
    //플레이어이동
    void Move(float _lockTime, Vector3 _diraction)
    {
        m_isKeyLock = false;
        StartCoroutine(MoveCo(_lockTime, transform.position + _diraction));
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
        m_isKeyLock = true;

    }
}
