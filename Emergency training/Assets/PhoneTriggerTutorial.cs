using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PhoneTriggerTutorial : MonoBehaviour
{
    public GameObject FinishMessage;
    bool GameFinished;

    // Update is called once per frame
    void Update()
    {
        if (GameFinished == true && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player") && Input.GetKey(KeyCode.E))
        {
            FinishMessage.SetActive(true);
            GameFinished = true;
        }

    }
}
