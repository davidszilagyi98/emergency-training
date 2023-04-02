using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroQuiz : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Question myQuestion = QuizManager.Instance.GetQuestion(0);

            Debug.Log(myQuestion.question + " -- Answer: " + myQuestion.answer);

            myQuestion.isCorrect = true;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            bool answer = QuizManager.Instance.ValidateQuestionAnswer(0, "Hejsa");

            QuizManager.Instance.SetAnswerCorrect(1);
        }


        foreach(Question q in QuizManager.Instance.questions)
        {
            q.isCorrect = false;
        }
    }
}
