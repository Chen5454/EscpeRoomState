using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public BaseState currentState;
    public string myKey;
    public string Name;
    public bool Transport;
    public bool containsKey;
    public GameObject room2;
    public KeyItems key;
    //public GameObject keyImage;
    private void Start()
    {
        currentState = new CloseState(myKey);

        if (key != null)
        {
            key.Init();
        }
    }

    public void ClickMe(string i)
    {
        if (currentState.DoState(i))
        {
            currentState = new OpenState();

            GameController.instance.showDialogue("Used " + i + " to open " + Name);

        }
        else
        {
            GameController.instance.showDialogue(Name + " is locked");
        }
    }

}
