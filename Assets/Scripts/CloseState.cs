using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseState : BaseState
{
    public string myKey;
    public CloseState(string i)
    {
        myKey = i;
    }
    public bool DoState(string i)
    {
        Debug.Log("RightKey? " + (i == myKey));
        return i == myKey;
    }
   
}
