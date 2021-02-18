using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class KeyItems : MonoBehaviour
{
    [SerializeField]
    Interactable myLock;
    PlayerCast player;
    [SerializeField]
    public Item theRightKey;

    public bool isPickedUp;
    public bool isOnce;
    public SpriteRenderer itemImage;
   

    private void Start()
    {

        Init();
        //player = GameObject.FindObjectOfType<PlayerCast>();


    }


    public void Init()
    {
        isOnce = true;

    }

    public void PickMeUp()
    {
        PlayerCast.instance.inventory.Add(theRightKey);
        //myLock.currentState = new OpenState(me);
        gameObject.SetActive(false);
        isPickedUp = true;
        UIManager.instance.ActivateButtons(this);

    }

   
}
