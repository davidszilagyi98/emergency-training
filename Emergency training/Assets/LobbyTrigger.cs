using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyTrigger : MonoBehaviour
{
    public GameObject Step1;
    public GameObject Step2;

    private void Start()
    {
        Step1.SetActive(true);
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag.Equals("Player"))
        {
            Step1.SetActive(false);
            Step2.SetActive(true);
        }
    }
}
