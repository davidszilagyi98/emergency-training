// using UnityEngine;

// public class alarmsound : MonoBehaviour
// {
//     public AudioClip soundClip;
//     private AudioSource audioSource;
//     public GameObject particleSystemObject;
//     public rotatethis rotationScript;

//     void Start()
//     {
//         audioSource = GetComponent<AudioSource>();
//         particleSystemObject.SetActive(false); // disable particle system by default
//         rotationScript.enabled = false; // disable rotation script by default
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.E))
//         {
//             audioSource.PlayOneShot(soundClip);
//             particleSystemObject.SetActive(true); // enable particle system
//             rotationScript.enabled = true; // enable rotation script
//         }
//     }
// }

using UnityEngine;

public class alarmsound : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;
    public GameObject particleSystemObject;
    public rotatethis rotationScript;

    private bool isPlayerInRange = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        particleSystemObject.SetActive(false); // disable particle system by default
        rotationScript.enabled = false; // disable rotation script by default
    }

    void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(soundClip);
            particleSystemObject.SetActive(true); // enable particle system
            rotationScript.enabled = true; // enable rotation script
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
