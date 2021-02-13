using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerCast playerRef;

    public Button[] buttonsArray = new Button[4];

    private int buttonCounter=0;


    private int spaceBetweenButtons = 0;

    public static UIManager instance;

    private void Start()
    {
        playerRef = GetComponent<PlayerCast>();

        instance = this;
    }


    public void ActivateButtons(KeyItems item)
    {

        if (item.isPickedUp)
        {
            
            buttonsArray[buttonCounter].gameObject.SetActive(true);

            if (item.isOnce)
            {
                buttonsArray[buttonCounter].gameObject.transform.position += new Vector3(spaceBetweenButtons, 0, 0);
                spaceBetweenButtons += 80;
                buttonsArray[buttonCounter].GetComponentInChildren<Image>().sprite = item.itemImage.sprite;
                buttonsArray[buttonCounter].GetComponent<InventoryButtonActive>().items = item.me;
                item.isOnce = false;
            }
            buttonCounter++;
        }

        //if (paperClipRef.isPickedUp )
        //{

        //    buttons[1].gameObject.SetActive(true);
        //    if (paperClipRef.isOnce)
        //    {
        //        buttons[1].gameObject.transform.position += new Vector3(activeButton, 0, 0);
        //        activeButton += 80;

        //        paperClipRef.isOnce = false;
        //    }
        //}

    }


}
