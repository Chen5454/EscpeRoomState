using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum item {none , paperclip , key  }
//public enum interactable {none , drawer , door } 

public class PlayerCast : MonoBehaviour
{
    public Camera cam;
    public List<item> inventory;
    public item activeItem;

    private void Start()
    {
        inventory = new List<item>();
        
    }

    // Update is called once per frame
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

    public void SelectKey()
    {
        this.activeItem = item.key;
        Debug.Log("CLicked");

    }

    


}
