using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private void Update()
    {
        buttonOpen();
        buttonClose();
    }

    /*private void OnTriggerEnter2D(Collider2D other)
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
    }*/

    public void buttonOpen()
    {
        if (LevelManager.instance.gotKey && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("has key, button triggered");
            LevelManager.instance.OpenDoor();
        }
    }
    
    public void buttonClose()
    {
        if (LevelManager.instance.gotKey && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("has key, button triggered");
            LevelManager.instance.CloseDoor();
        }
    }
}
