using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//------------------------------------------------------------------------------------------------

// I didn't add any movement as David is working on it but thought this might help :-) 
//We just need to add it to the PlayerController David makes.

//------------------------------------------------------------------------------------------------
public class SamplePlayerController : MonoBehaviour
{
    CameraShaker cameraShaker;
    ScreenFlasher screenFlasher;
    Timer timer;



    private void Awake()
    {
        cameraShaker = FindObjectOfType<CameraShaker>();

        screenFlasher = FindObjectOfType<ScreenFlasher>();

        timer = FindObjectOfType<Timer>();
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Flash")) // check if the player collides with the flash spots
        {
            screenFlasher.flashScreen();
        }

        if (collision.gameObject.CompareTag("GameOver"))
        {
            timer.StopTimer();
        }

        if (collision.gameObject.CompareTag("Shake")) // check if the player collides with the shake spots
        {
            cameraShaker.ShakeCameraForOneSecond();
        }
    }


}
