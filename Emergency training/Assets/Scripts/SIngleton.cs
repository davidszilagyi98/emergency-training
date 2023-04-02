using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    public EscapeStep[] steps;

    //creating a singleton
    public int score;
    public static Singleton Instance;

    private void Awake()

    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // makes it work across scenes
        } else
        {
            Destroy(gameObject);
        }
    }

    public void SetAnswerCorrect(int index)
    {
        steps[index].isDone = true;
    }

    public bool ValidateQuestionAnswer(int index, bool isDone)
    {
        EscapeStep step = steps[index];
        if (step.isDone == false || true )
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
        index = Mathf.Clamp(index,0, steps.Length - 1);
        return steps[index];
    }

}
