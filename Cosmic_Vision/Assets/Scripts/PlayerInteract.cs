using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> interactableObjects = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && interactableObjects.Count != 0)
        {
            interactableObjects[0].GetComponent<IInteractable>().Interact();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<IInteractable>() != null)
        {
            interactableObjects.Insert(0, other.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.GetComponent<IInteractable>() != null)
        {
            interactableObjects.Remove(other.gameObject);
        }
    }
}
