using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public BaseState currentState;
    public Item myKey;
    public bool Transport;
    public bool containsKey;
    public GameObject room2;
    public KeyItems key;
    //public GameObject keyImage;
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
