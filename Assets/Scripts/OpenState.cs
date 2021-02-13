using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenState : BaseState
{
    public Interactable myLock;

    public bool DoState(Item i)
    {
        return true;
    }
  

}
