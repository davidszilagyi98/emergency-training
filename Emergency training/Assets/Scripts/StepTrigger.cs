using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StepTrigger : MonoBehaviour
{

    public bool isTriggered = false;
    public string zoneName;
    public TextMeshProUGUI feedbackText;

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


    private IEnumerator DisplayFeedback(string feedbackText)
    {
        // Display the feedback text for 5 seconds
        Debug.Log(feedbackText);
        yield return new WaitForSeconds(5f);
        Debug.Log("Feedback cleared");
    }

    // old update
    /*  private void Update()
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
      } */


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



    // update v3
    /*
    private IEnumerator DisplayFeedback(string feedbackText)
{
    // Display the feedback text for 5 seconds
    Debug.Log(feedbackText);
    yield return new WaitForSeconds(5f);
    Debug.Log("Feedback cleared");
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
                GameSystemMatej.Instance.currentStepIndex++;
                if (GameSystemMatej.Instance.currentStepIndex >= GameManagerMatej.Instance.steps.Length)
                {
                    GameSystemMatej.Instance.currentStepIndex = 0;
                }
                GameSystemMatej.Instance.UpdateUI();

                // Display the positive feedback message
                StartCoroutine(DisplayFeedback(currentStep.positiveFeedback));
            }
        }
        else
        {
            // Display the negative feedback message
            StartCoroutine(DisplayFeedback(currentStep.negativeFeedback));
        }
    }
}

    */
}
