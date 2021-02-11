using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerCast playerRef;

    public Button[] buttons = new Button[4];

    public KeyItems keyRef;
    public KeyItems paperClipRef;

    public int activeButton=0;

    
    private void Start()
    {
        playerRef = GetComponent<PlayerCast>();

    }


    private void Update()
    {
        ActivateButtons();

    }
    
    void ActivateButtons()
    {
        if (keyRef.isPickedUp)
        {
            
            buttons[0].gameObject.SetActive(true);
            if (keyRef.isOnce)
            {
                buttons[0].gameObject.transform.position += new Vector3(activeButton, 0, 0);
                activeButton += 80;
                keyRef.isOnce = false;
            }
        }

        if (paperClipRef.isPickedUp )
        {

            buttons[1].gameObject.SetActive(true);
            if (paperClipRef.isOnce)
            {
                buttons[1].gameObject.transform.position += new Vector3(activeButton, 0, 0);
                activeButton += 80;

                paperClipRef.isOnce = false;
            }
        }

    }


}
