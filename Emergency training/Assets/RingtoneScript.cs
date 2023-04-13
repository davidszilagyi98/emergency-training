using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingtoneScript : MonoBehaviour
{
    public bool isTriggered = false;
    public string zoneName;
    public AudioSource ringtone;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ringtone = GetComponent<AudioSource>();
        ringtone.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            ringtone.Stop();
        }
    }
}
