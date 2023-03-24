using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBesidesDoor : MonoBehaviour
{
    public bool isBesidesDoor;
    // Start is called before the first frame update
    void Start()
    {
        isBesidesDoor = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        isBesidesDoor = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isBesidesDoor = false;
    }
}
