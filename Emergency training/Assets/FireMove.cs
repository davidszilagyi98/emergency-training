using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMove : MonoBehaviour
{
    public GameObject arrow;
    public float moveSpeed = 5;
    public float deadZone = -8;

    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;

        if (transform.position.x > deadZone)
        { 
            Destroy(gameObject);
        }
    }
}
