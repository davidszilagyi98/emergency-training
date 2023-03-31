using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    public Question[] questions;

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

   
    public Question GetQuestions(int index)
    {
        index = Mathf.Clamp(index,0, questions.Length - 1);
        return questions[index];
    }

}
