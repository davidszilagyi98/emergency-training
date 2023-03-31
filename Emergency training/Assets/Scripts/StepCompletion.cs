using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MatejsGameManagerTest;

public class StepCompletion : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        // Get the GameManager instance from the scene
        //gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the CompleteCurrentStep method on the GameManager instance
            gameManager.CompleteCurrentStep();
        }
    }
}

