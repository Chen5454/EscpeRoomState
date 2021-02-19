using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButtonActive : MonoBehaviour
{
    public GameController playerRef;
    public string items;
    public void onInventoryClick()
    {
        playerRef.activeItem = items;
    }

   
}
