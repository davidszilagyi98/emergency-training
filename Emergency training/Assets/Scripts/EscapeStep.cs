using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EscapeStep : ScriptableObject
{
    public string title;
    public string description;
    public string positiveFeedback;
    public string negativeFeedback;
    public bool isDone;


    /*  // Start is called before the first frame update
      void Start()
      {
          Singleton.Instance.score = 10;
      }

      // Update is called once per frame
      void Update()
      {

      }*/
}
