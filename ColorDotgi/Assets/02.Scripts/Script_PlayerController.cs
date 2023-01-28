using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    [SerializeField] float m_lockTime;
    [SerializeField] bool m_isKeyLock;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Space) && m_isKeyLock)
            Move(m_lockTime);
    }

    //플레이어이동


    void Move(float _lockTime)//, string _diraction)
    {
        m_isKeyLock = false;
        StartCoroutine(MoveCo(_lockTime, transform.position + new Vector3(1,1,0)));
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
