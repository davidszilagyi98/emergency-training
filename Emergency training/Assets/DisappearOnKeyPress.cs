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

using UnityEngine;

public class DisappearOnKeyPress : MonoBehaviour
{
    public ParticleSystem particles; // assign the particle system in the inspector
    public ParticleSystem Fire;

    private bool isDisappeared = false; // flag to track if the object has already disappeared

    void Start()
    {
        particles.Stop(); // stop the particle system on startup
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isDisappeared) // check if E key is pressed and the object hasn't already disappeared
        {
            isDisappeared = true; // set the flag to true to prevent multiple disappearances

            if (particles != null) // check if the particle system is assigned
            {
                particles.Play(); // play the particle system
            }

            if (isDisappeared){
                Fire.Play();
            }

            gameObject.SetActive(false); // disable the object
        }
    }
}


// using UnityEngine;

// public class DisappearOnKeyPress : MonoBehaviour
// {
//     public ParticleSystem particles; // assign the particle system in the inspector
//     public ParticleSystem secondaryParticles; // assign the secondary particle system in the inspector

//     private bool isDisappeared = false; // flag to track if the object has already disappeared
//     private bool hasPlayedParticles = false; // flag to track if the first particle system has finished playing

//     void Start()
//     {
//         particles.Stop(); // stop the particle system on startup
//         if (secondaryParticles != null)
//         {
//             secondaryParticles.Stop(); // stop the secondary particle system on startup
//         }
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.E) && !isDisappeared) // check if E key is pressed and the object hasn't already disappeared
//         {
//             isDisappeared = true; // set the flag to true to prevent multiple disappearances

//             if (particles != null) // check if the particle system is assigned
//             {
//                 particles.Play(); // play the particle system
//             }

//             gameObject.SetActive(false); // disable the object
//         }

//         // check if the first particle system has finished playing and play the secondary particle system
//         if (isDisappeared && particles != null && !particles.isPlaying && !hasPlayedParticles)
//         {
//             hasPlayedParticles = true;
//             if (secondaryParticles != null)
//             {
//                 if (secondaryParticles.transform.parent == null)
//                 {
//                     secondaryParticles.transform.parent = transform;
//                 }
//                 secondaryParticles.Play();
//             }
//         }
//     }
// }
