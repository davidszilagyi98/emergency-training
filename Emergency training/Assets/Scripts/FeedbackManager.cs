using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FeedbackManager : MonoBehaviour
{
    public static FeedbackManager Instance { get; private set; }
    public  TextMeshProUGUI feedbackText;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /* public IEnumerator DisplayStepFeedback(TextMeshProUGUI feedbackText)
     {
         EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex - 1);
         // Display the feedback text for 5 seconds
         feedbackText.text = currentStep.positiveFeedback.ToString(); ; // update the text field
         Debug.Log(feedbackText);
         yield return new WaitForSeconds(5f);
         feedbackText.text = ""; // clear the text field after 5 seconds
         Debug.Log("Feedback cleared");
     } */


    /*  public void ShowPositiveFeedback()
      {
          EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex);
          feedbackText.text = currentStep.positiveFeedback;
          StartCoroutine(ClearFeedback());
      } */

    public void ShowPositiveFeedback()
    {

        int currentStepIndex = GameSystemMatej.Instance.currentStepIndex;
        Debug.Log(currentStepIndex);
      if (currentStepIndex < 0)
        {
         
            //feedbackText.text = GameManagerMatej.Instance.GetSteps(0).positiveFeedback; //steps[0].positiveFeedback;
        }
        else
        {
            currentStepIndex--;
        } 

        EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(currentStepIndex);

        if (currentStepIndex < 0 )//&& currentStep.title == "Call Firefighters")
        {
            feedbackText.text = GameManagerMatej.Instance.steps[0].positiveFeedback;
        }
        else
        {
            feedbackText.text = currentStep.positiveFeedback;
        }

        StartCoroutine(ClearFeedback());
    }






    public void ShowNegativeFeedback()
    {
        EscapeStep currentStep = GameManagerMatej.Instance.GetSteps(GameSystemMatej.Instance.currentStepIndex);
        feedbackText.text = currentStep.negativeFeedback;
        StartCoroutine(ClearFeedback());
    }

    public IEnumerator ClearFeedback()
    {
        yield return new WaitForSeconds(5f);
        feedbackText.text = "";
    }

}
