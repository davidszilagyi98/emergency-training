using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimeText;


    private float startTime; // The time the timer started
    private bool isRunning; // Whether the timer is running

    private void Start()
    {
        // Start the timer
        StartTimer();
    }

    private void Update()
    {
        if (isRunning)
        {
            // Update the text with the current time
            float currentTime = Time.time - startTime;
            string minutes = Mathf.Floor(currentTime / 60f).ToString("00");
            string seconds = (currentTime % 60f).ToString("00");
            TimeText.text = currentTime.ToString();
        }
    }

    public void StartTimer()
    {
        // Start the timer
        startTime = Time.time;
        isRunning = true;
    }

    public void StopTimer()
    {
        // Stop the timer
        isRunning = false;
    }

}
