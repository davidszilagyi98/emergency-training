// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DisappearOnKeyPress : MonoBehaviour
// {
//     public GameObject graphics;
//     public ParticleSystem partSys;

//     public KeyCode interactKey = KeyCode.E;

//     private bool hasExploded = false;

//     private bool playerInside = false;

//     private void Update()
//     {
//         if (Input.GetKeyDown(interactKey) && playerInside == true && !hasExploded)
//         {
//             hasExploded = true;
//             graphics.SetActive(false);
//             partSys.Play();

//         }
//     }

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Player"))
//         {
//             playerInside = true;
//         }        
//     }

//     void OnTriggerExit(Collider other)
//     {
//         if (other.gameObject.CompareTag("Player"))
//         {
//             playerInside = false;
//         }
//     }
// }

// using UnityEngine;

// public class DisappearOnKeyPress : MonoBehaviour
// {
//     public ParticleSystem particles; // assign the particle system in the inspector
//     public ParticleSystem Fire;

//     private bool isDisappeared = false; // flag to track if the object has already disappeared

//     // void Start()
//     // {
//     //     particles.Stop(); // stop the particle system on startup
        
//     // }

//     void Update()
//     {
//          particles.Stop();
//         if (Input.GetKeyDown(KeyCode.E) && !isDisappeared) // check if E key is pressed and the object hasn't already disappeared
//         {
//             isDisappeared = true; // set the flag to true to prevent multiple disappearances

//             if (particles != null) // check if the particle system is assigned
//             {
//                 particles.Play(); // play the particle system
//             }

//             if (isDisappeared){
//                 Fire.Play();
//             }

//             gameObject.SetActive(false); // disable the object
//         }
//     }
// }

using UnityEngine;

public class DisappearOnKeyPress : MonoBehaviour
{
    public GameObject Step3;
    public GameObject Step4;
    public GameObject Fire1;

    public ParticleSystem particles; // assign the particle system in the inspector
    public ParticleSystem Fire;
    public float distanceToActivate = 2f; // the distance at which the player can activate the object

    private bool isDisappeared = false; // flag to track if the object has already disappeared
    private bool playerInRange = false; // flag to track if the player is in range to activate the object

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !isDisappeared) // check if E key is pressed and the object hasn't already disappeared and the player is in range
        {
            isDisappeared = true; // set the flag to true to prevent multiple disappearances

            if (particles != null) // check if the particle system is assigned
            {
                particles.Play(); // play the particle system
            }

            if (isDisappeared)
            {
                Fire.Play();
                Fire1.SetActive(true);
            }

            gameObject.SetActive(false); // disable the object

            Step3.SetActive(false);
            Step4.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true; // set the playerInRange flag to true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false; // set the playerInRange flag to false
        }
    }

    private void OnDrawGizmosSelected()
    {
        // draw a wireframe sphere around the object to visualize the trigger zone
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanceToActivate);
    }
}
