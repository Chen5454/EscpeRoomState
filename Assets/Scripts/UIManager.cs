using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameController playerRef;

    public Button[] buttonsArray = new Button[4];

    private int buttonCounter=0;


    private int spaceBetweenButtons = 0;

    public static UIManager instance;

    private void Start()
    {
        playerRef = GetComponent<GameController>();

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
                buttonsArray[buttonCounter].GetComponent<InventoryButtonActive>().items = item.theRightKey;
                item.isOnce = false;
            }
            buttonCounter++;
        }

    }


}
