using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyDoorOpener : MonoBehaviour
{
    public GameObject affectedGameObject;
    private bool playerInside = false;

    public KeyCode interactKey = KeyCode.E;


    private void Update()
    {
        if (Input.GetKeyDown(interactKey) && playerInside == true)
        {
            // Do the animation
            Vector3 eulerAngles = affectedGameObject.transform.rotation.eulerAngles;
            float x = eulerAngles.x;
            float y = eulerAngles.y;
            float z = eulerAngles.z;



            y += 90f; // make it a couroutine



            affectedGameObject.transform.rotation = Quaternion.Euler(x, y, z);
        }
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        playerInside = true;

    }

    void OnTriggerExit(Collider other)
    {
        playerInside = false;
    }

}
