using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMatej : MonoBehaviour
{
    public EscapeStep[] steps;

    //creating a singleton
    //public int score;
    public static GameManagerMatej Instance;

    private void Awake()

    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // makes it work across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetAnswerCorrect(int index)
    {
        steps[index].isDone = true;
    }

    public bool ValidateStepDone(int index, bool isDone)
    {
        EscapeStep step = steps[index];
        if (step.isDone == false || true)
        {
            return true;
        }

        return false;
    }


    /*public void completeCurrentStep()
    {

    }*/

    public EscapeStep GetSteps(int index)
    {
        index = Mathf.Clamp(index, 0, steps.Length - 1);
        EscapeStep step = steps[index];

        // check if the current step is done
        if (step.isDone)
        {
            // move to the next step
            index++;
            // if we've reached the end of the array, loop back to the beginning
            if (index >= steps.Length)
            {
                index = 0;
            }
            step = steps[index];
        }

        return step;
    } 


    /* public EscapeStep GetSteps(int index)
     {
         index = Mathf.Clamp(index, 0, steps.Length - 1);
         return steps[index];
     } */


}
