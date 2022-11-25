using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManger
{
    public Action KetAction = null;

    public void OnUpdate()
    {
        if (Input.anyKey == false)
        {
            return;
        }

        if (KetAction != null)
        {
            KetAction.Invoke();
        }
    }
}