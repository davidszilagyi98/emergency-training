using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneSwitch : MonoBehaviour
{
    public bool isTriggered = false;
    public string zoneName;
    public GameObject Call1;
    public GameObject Call2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }

    private void Update()
    {
        if (isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex);

            // Check if the title of the current step matches the zoneName string of this trigger
            if (currentStep.title == zoneName)
            {
                currentStep.isDone = true;
                if (currentStep.isDone)
                {
                 
                    Call2.SetActive(true);
                }
            }
        }
    }
}
