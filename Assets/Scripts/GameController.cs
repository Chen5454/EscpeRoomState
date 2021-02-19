using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Item {none , paperclip , key  }

public class GameController : MonoBehaviour
{
    public Camera cam;
    public List<KeyItems> inventory;
    public string activeItem;
    public static GameController instance;

    public GameObject CurrentRoom;

    public Text GameTextBox;


    private void Start()
    {
        inventory = new List<KeyItems>();
        instance = this;
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

                    if (interactable.currentState is OpenState && interactable.Transport)
                    {
                        SwitchRooms(interactable);
                    }
                    if (interactable.currentState is OpenState && interactable.containsKey)
                    {

                        interactable.key.PickMeUp();
                        interactable.containsKey = false;
                    }
                    else
                    {
                        interactable.CLickMe(activeItem);
                    }

                }
                else if (hit.collider.CompareTag("Key"))
                {
                    KeyItems hitItem = hit.collider.gameObject.GetComponent<KeyItems>();
                    hitItem.PickMeUp();
                }

            }
        }

    }

    public void SwitchRooms(Interactable Door)
    {
        CurrentRoom.gameObject.SetActive(false);
        Door.room2.SetActive(true);
        CurrentRoom = Door.room2;
    }

    public void showDialogue(string text)
    {
        GameTextBox.text = text;
    }
}
