using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Item {none , paperclip , key  }

public class PlayerCast : MonoBehaviour
{
    public Camera cam;
    public List<Item> inventory;
    public Item activeItem;

    private void Start()
    {
        inventory = new List<Item>();
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.CompareTag("Interact"))
                {
                    Interactable interactable = hit.collider.gameObject.GetComponent<Interactable>();
                    interactable.CLickMe(activeItem);
                    
                }
                else if(hit.collider.CompareTag("Key"))
                {
                     KeyItems hitItem = hit.collider.gameObject.GetComponent<KeyItems>();
                    hitItem.PickMeUp();
                }

            }
        }

    }

    public void ButtonSelect()  //this is the generic button im trying to do
    {
        this.activeItem = Item.key;
        Debug.Log("Clicked");

    }




}
