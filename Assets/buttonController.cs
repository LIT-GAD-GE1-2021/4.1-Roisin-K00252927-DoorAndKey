using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    //private GameObject theCharacter;
    //private inventory theInventory;

    // Start is called before the first frame update
    void Awake()
    {
        //theCharacter = GameObject.FindWithTag("Player");
        //theInventory = theCharacter.GetComponent<inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (LevelManager.instance.gotKey)
        {
            Debug.Log("has key, button triggered");
            LevelManager.instance.OpenDoor();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        ;
    }
}
