using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenState : BaseState
{
    public item myKey;
    public Interactable myLock;
    public OpenState(item myNewKey) 
    {
        myKey = myNewKey;
    }

    public bool DoState(item i)
    {
        Debug.Log("RightKey?" + (i==myKey).ToString());
       return i==myKey;
        
    }
}
