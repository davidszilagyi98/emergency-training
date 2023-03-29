using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    AudioSource audioData;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
}
