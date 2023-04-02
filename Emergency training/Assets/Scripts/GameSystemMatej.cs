using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameSystemMatej : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public int currentStepIndex = 0;

    public static GameSystemMatej Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }
  /*  private void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            EscapeStep myStep = GameManagerMatej.Instance.GetSteps(currentStepIndex);
            titleText.text = myStep.title.ToString();
            descriptionText.text = myStep.description.ToString();

            // Only increment currentStepIndex if the current step is marked as done
            if (myStep.isDone)
            {
                currentStepIndex++;
                if (currentStepIndex >= GameManagerMatej.Instance.steps.Length)
                {
                    currentStepIndex = 0;
                }
                {
                    UpdateUI();
                }
            }

            //currentStepIndex++;
            //currentStepIndex = (currentStepIndex + 1) % GameManagerMatej.Instance.steps.Length;
            //Debug.Log(myStep.title+ " " + myStep.description);
        }
    } */

    public void UpdateUI()
    {
        EscapeStep myStep = GameManagerMatej.Instance.GetSteps(currentStepIndex);
        titleText.text = myStep.title.ToString();
        descriptionText.text = myStep.description.ToString();
        // Only increment currentStepIndex if the current step is marked as done
        if (myStep.isDone)
        {
            //currentStepIndex++;
            if (currentStepIndex >= GameManagerMatej.Instance.steps.Length)
            {
                currentStepIndex = 0;
            }

        }
    }
}
