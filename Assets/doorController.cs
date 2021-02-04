using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class doorController : MonoBehaviour
{
    private GameObject theDoor;

    // Start is called before the first frame update
    void Awake()
    {
        theDoor = GameObject.FindWithTag("door");
        theDoor.GetComponent<Transform>();
    }

    public void StartOpen()
    {
        Debug.Log("triggered coroutine");
        IEnumerator theCoroutine;
        theCoroutine = SlowlyOpen();
        StartCoroutine(theCoroutine);
    }

    IEnumerator SlowlyOpen()
    {
        for (float i = 2.5f; i >= 0.0f; i -= 0.1f)
        {
            /* theDoor.transform.Translate(Vector3.up * i);
            yield return null;
            Debug.Log("coroutine is running"); 
            */
            Vector3 pos = theDoor.transform.position;
            pos.y = pos.y + 0.1f;
            theDoor.transform.position = pos;
            yield return new WaitForSeconds(.1f);
        }
    }
}
