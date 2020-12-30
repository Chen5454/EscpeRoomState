using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseState : BaseState
{
    public bool DoState(item i)
    {
        Debug.Log("Can't Open");
        return false;
    }
}
