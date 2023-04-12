using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KasperTrigger : MonoBehaviour
{
    public GameObject Step2;
    public GameObject Step3;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player") && Input.GetKeyDown(KeyCode.E))
        {
            Step2.SetActive(false);
            Step3.SetActive(true);
        }
    }

}
