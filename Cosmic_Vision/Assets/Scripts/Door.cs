using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    GameObject player;
    public bool infrontDoor;
    SpriteRenderer render;
    BoxCollider2D collid;
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
        render = GetComponent<SpriteRenderer>();
        collid = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(Mathf.Abs(transform.position.x - player.transform.position.x) > 2.5f && infrontDoor)
        {
            flipDoor();
            infrontDoor = false;
        }
    }
    public void Interact()
    {
        Debug.Log("hallo");
        infrontDoor = true;
        flipDoor();
    }
    void flipDoor()
    {
        render.enabled = !render.enabled;
        collid.enabled = !collid.enabled;
    }
}
