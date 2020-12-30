using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public BaseState currentState;
    public item myKey;

    private void Start()
    {
        currentState = new CloseState();
    }

    public void CLickMe(item i)
    {
        currentState.DoState(i);
            
    }

}
