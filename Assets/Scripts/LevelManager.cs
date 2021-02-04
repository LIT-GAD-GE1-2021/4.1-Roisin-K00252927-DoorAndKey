using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The LevelManager from the Week 6 Lecture
 */
public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    private GameObject theDoor;
    private doorController theDoorController;
    
    public bool gotKey = false;

    private void Awake()
    {
        // set the instance property/variable to this object
        instance = this;
        theDoor = GameObject.FindWithTag("door");
        theDoorController = theDoor.GetComponent<doorController>();
    }

    public void OpenDoor()
    {
        theDoorController.StartOpen();
    }
}
