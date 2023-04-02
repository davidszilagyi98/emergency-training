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
            EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex);
            if (currentStep.isDone)
            {
                GameSystemMatej.Instance.currentStepIndex++;
                if (GameSystemMatej.Instance.currentStepIndex >= GameManagerMatej.Instance.steps.Length)
                {
                    GameSystemMatej.Instance.currentStepIndex = 0;
                }
                GameSystemMatej.Instance.UpdateUI();
            }
        }
    }
}
