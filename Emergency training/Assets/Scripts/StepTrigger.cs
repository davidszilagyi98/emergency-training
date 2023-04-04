using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StepTrigger : MonoBehaviour
{

    public bool isTriggered = false;
    public string zoneName;

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
            Debug.Log("A");
            EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex);
            currentStep.isDone = true; //For fucks sake how did I forget this?? And how did it work without it??
            if (currentStep.isDone)
            {
                Debug.Log("B");
                GameSystemMatej.Instance.currentStepIndex++;
                if (GameSystemMatej.Instance.currentStepIndex >= GameManagerMatej.Instance.steps.Length)
                {
                    Debug.Log("C");
                    GameSystemMatej.Instance.currentStepIndex = 0;
                }
                GameSystemMatej.Instance.UpdateUI();
            }
        }
    }
}
