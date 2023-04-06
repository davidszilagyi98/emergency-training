using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMove2 : MonoBehaviour
{
    public GameObject arrow;
    public float moveSpeed = 5;
    public float deadZone = 5;

    void Update()
    {
        transform.position = transform.position + (Vector3.forward * moveSpeed) * Time.deltaTime;

        if (transform.position.z > deadZone)
        {
            Destroy(gameObject);
        }
    }
}
