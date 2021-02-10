using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseState : BaseState
{
    public item myKey;
    public CloseState(item i)
    {
        myKey = i;
    }
    public bool DoState(item i)
    {
        Debug.Log("RightKey?" + (i == myKey).ToString());
        return i == myKey;
    }
   
}
