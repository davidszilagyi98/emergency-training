using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroQuiz : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Question myQuestion = Singleton.Instance.GetQuestions(0);
            Debug.Log(myQuestion.title+ " " + myQuestion.description);
        }
    }

}
