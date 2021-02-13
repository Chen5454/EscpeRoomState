using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public BaseState currentState;
    public Item myKey;

    private void Start()
    {
        currentState = new CloseState(myKey);
    }

    public void CLickMe(Item i)
    {
        if (currentState.DoState(i))
        {
            currentState = new OpenState();
        }
        
    }

}
