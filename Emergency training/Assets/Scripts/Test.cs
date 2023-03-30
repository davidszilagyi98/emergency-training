using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using Unity.VisualScripting;


public class Test : MonoBehaviour
{
   public enum Steps
    {
        EvacuationPlan,
        FireExtinguisher,
        SmokeDetector,
        EmergencyContacts,
        EmergencyEscapeRoute
    }

    Steps currentStep = Steps.EvacuationPlan;
    public TextMeshProUGUI stepTitle;

    private void Start()
    {
        // Get reference to UI TextMeshProUGUI component
        stepTitle = GetComponent<TextMeshProUGUI>();
        // Display the title of the initial step
        stepTitle.text = currentStep.ToString();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            // Move to the next step
            currentStep++;
            // I'll just make a loop for testing purposes
            if (currentStep > Steps.EmergencyEscapeRoute)
            {
                currentStep = Steps.EvacuationPlan;
            }
            // Update the UI with the new step title
            stepTitle.text = currentStep.ToString();
        }
    }
}


