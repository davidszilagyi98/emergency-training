using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSystemMatej : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    private int currentStepIndex = 0;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            EscapeStep myStep = GameManagerMatej.Instance.GetSteps(currentStepIndex);
            titleText.text = myStep.title.ToString();
            descriptionText.text = myStep.description.ToString();
            currentStepIndex++;
            //currentStepIndex = (currentStepIndex + 1) % GameManagerMatej.Instance.steps.Length;
            //Debug.Log(myStep.title+ " " + myStep.description);
        }
    }

}
