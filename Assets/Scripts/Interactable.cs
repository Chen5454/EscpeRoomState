using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public BaseState currentState;
    public item myKey;

    private void Start()
    {
        currentState = new CloseState(myKey);
    }

    public void CLickMe(item i)
    {
        if (currentState.DoState(i))
        {
            currentState = new OpenState();
        }
        
    }

}
