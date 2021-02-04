using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "key")
        {
            LevelManager.instance.gotKey = true;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        ;
    }
}
