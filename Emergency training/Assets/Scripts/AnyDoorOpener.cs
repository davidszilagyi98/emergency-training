using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyDoorOpener : MonoBehaviour
{
    public GameObject affectedGameObject;
    private bool playerInside = false;
    public float doorOpenTime = 1.0f;
    public bool doorOpen;

    public KeyCode interactKey = KeyCode.E;


    public IEnumerator OpenDoor()
    {
        Vector3 eulerAngles = affectedGameObject.transform.rotation.eulerAngles;
        float x = eulerAngles.x;
        float y = eulerAngles.y;
        float z = eulerAngles.z;

        float initialY = y;
        float finalY = initialY + 90.0f;

        float startTime = Time.time;

        while (Time.time < startTime + doorOpenTime)
        {
            float t = (Time.time - startTime) / doorOpenTime;
            y = Mathf.Lerp(initialY, finalY, t);

            affectedGameObject.transform.rotation = Quaternion.Euler(x, y, z);
            yield return null;
        }

        affectedGameObject.transform.rotation = Quaternion.Euler(x, finalY, z);
        doorOpen = true;
    }

    public IEnumerator CloseDoor()
    {
        Vector3 eulerAngles = affectedGameObject.transform.rotation.eulerAngles;
        float x = eulerAngles.x;
        float y = eulerAngles.y;
        float z = eulerAngles.z;

        float initialY = y;
        float finalY = initialY - 90.0f;

        float startTime = Time.time;

        while (Time.time < startTime + doorOpenTime)
        {
            float t = (Time.time - startTime) / doorOpenTime;
            y = Mathf.Lerp(initialY, finalY, t);

            affectedGameObject.transform.rotation = Quaternion.Euler(x, y, z);
            yield return null;
        }

        affectedGameObject.transform.rotation = Quaternion.Euler(x, finalY, z);
        doorOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(interactKey) && playerInside == true && doorOpen == false)
        {
            StartCoroutine(OpenDoor());
        }
        if (Input.GetKeyDown(interactKey) && playerInside == true && doorOpen == true)
        {
            StartCoroutine(CloseDoor());
        }

    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)

    {
        playerInside = true;
    }
    /*{
        if (other.gameObject.CompareTag("Door") || other.gameObject.CompareTag("Window"))
        {
            affectedGameObject = other.gameObject;
            playerInside = true;
        }
    }*/

    void OnTriggerExit(Collider other)

    {
        playerInside = false;
    }
    /* {
         if (other.gameObject.CompareTag("Door") || other.gameObject.CompareTag("Window"))
         {
             playerInside = false;
         }
     }*/
    /*{
        if (other.gameObject == affectedGameObject)
    {
        affectedGameObject = null;
        playerInside = false;
    }
    }*/

}
