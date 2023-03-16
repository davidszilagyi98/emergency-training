using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraShaker : MonoBehaviour
{
    public Transform CameraTransform;
    public float intensity = 0.1f;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = CameraTransform.localPosition;
    }

    public void ShakeCameraForOneSecond()
    {
        StartCoroutine(ShakeCoroutine());
    }

    IEnumerator ShakeCoroutine()
    {
        float elapsed = 0.0f;
        while (elapsed < 0.5f)
        {
            float RandX = Random.Range(-0.1f, 0.1f);
            float RandY = Random.Range(-0.1f, 0.1f);
            float RandZ = Random.Range(-0.1f, 0.1f);

            CameraTransform.localPosition = new Vector3(RandX, RandY, RandZ).normalized * intensity;
            elapsed += Time.deltaTime;
            yield return null;
        }
        CameraTransform.localPosition = originalPosition;
    }
}


