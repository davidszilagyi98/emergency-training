using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFlasher : MonoBehaviour
{
    public CanvasGroup flashingScreen;
    public AnimationCurve flashCurve;
    public float timer = 0.3f;
    //private bool flash = false;

    // Start is called before the first frame update
    void Start()
    {
        flashingScreen.alpha = 0f;
    }

    public void flashScreen()
    {
        StartCoroutine(ScreenFlash(timer));
    }

    IEnumerator ScreenFlash(float timer)
    {
        for (float f = 0f; f < timer; f += Time.deltaTime)
        {
            float perc = f / timer;
            flashingScreen.alpha = flashCurve.Evaluate(perc);
            yield return null;
        }

        for (float f = 0f; f < timer; f += Time.deltaTime)
        {
            float perc = f / timer;
            flashingScreen.alpha = flashCurve.Evaluate(1 - perc);
            yield return null;
        }

        flashingScreen.alpha = 0f;
    }
    }
