using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpread : MonoBehaviour
{
    public GameObject arrow;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnArrow();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnArrow();
            timer = 0;
        }
    }
    void spawnArrow()
    {
        float lowestPoint = transform.position.z - heightOffset;
        float highestPoint = transform.position.z + heightOffset;


        Instantiate(arrow, new Vector3(transform.position.x, transform.position.y, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }

}