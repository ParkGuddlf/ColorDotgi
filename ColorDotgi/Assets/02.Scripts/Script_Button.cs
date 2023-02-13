using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Script_Button : MonoBehaviour, IPointerEnterHandler//, IPointerClickHandler
{
    private float doubleClickTimeLimit = 0.2f;
    public Vector3 _vector3;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!Script_PlayerController.instance.m_isKeyLock)
            return;

        StartCoroutine(InputListener());
    }

    private IEnumerator InputListener()
    {
        if (Input.GetMouseButtonDown(0))
            yield return ClickEvent();
    }
    private IEnumerator ClickEvent()
    {
        //pause a frame so you don't pick up the same mouse down event.
        yield return new WaitForEndOfFrame();

        float count = 0f;
        while (count < doubleClickTimeLimit)
        {
            if (Input.GetMouseButtonDown(0))
            {
                DoubleClick();
                yield break;
            }
            count += Time.deltaTime;// increment counter by change in time between frames
            yield return null; // wait for the next frame
        }
        if(Script_PlayerController.instance.m_isKeyLock)
            SingleClick();
    }


    private void SingleClick()
    {
        Debug.Log("Single Click");
        Script_PlayerController.instance.Move(1, _vector3);
    }

    private void DoubleClick()
    {
        Debug.Log("Double Click");
        Script_PlayerController.instance.Move(2, _vector3);
    }

}
