using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItems : MonoBehaviour
{
    [SerializeField]
    Interactable myLock;
    PlayerCast player;
    [SerializeField]
    item me;
    private void Start()
    {

        player = GameObject.FindObjectOfType<PlayerCast>(); 
    }



    public void PickMeUp()
    {
        player.inventory.Add(me);
        myLock.currentState = new OpenState(me);
        gameObject.SetActive(false);
    }
        

}
