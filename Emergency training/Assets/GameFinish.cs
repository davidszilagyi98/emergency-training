using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            FinishMessage.SetActive(true);
            GameFinished = true;
        }

    }
}
