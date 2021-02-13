using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseState : BaseState
{
    public Item myKey;
    public CloseState(Item i)
    {
        myKey = i;
    }
    public bool DoState(Item i)
    {
        Debug.Log("RightKey?" + (i == myKey).ToString());
        return i == myKey;
    }
   
}
