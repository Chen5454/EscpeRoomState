using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class KeyItems : MonoBehaviour
{
    [SerializeField]
    public String theRightKey;

    public bool isPickedUp;
    public bool isOnce;
    public SpriteRenderer itemImage;
    public string Name;

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
        GameController.instance.inventory.Add(this);
        gameObject.SetActive(false);
        isPickedUp = true;
        UIManager.instance.ActivateButtons(this);
        GameController.instance.showDialogue("picked up " + Name);
    }

   
}
