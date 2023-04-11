using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public AudioSource help;
    public bool studentSaved;
    public bool IsAround;
    public GameObject wayPoint;
    private Vector3 wayPointPos;
    //This will be the zombie's speed. Adjust as necessary.
    public float speed = 6.0f;
    void Start()
    {
        //At the start of the game, the zombies will find the gameobject called wayPoint.
        wayPoint = GameObject.Find("wayPoint");
        help = GetComponent<AudioSource>();
        help.Play();
    }

    void Update()
    {
        if (studentSaved == true)
        {

            if (IsAround == false)
            {
                wayPointPos = new Vector3(wayPoint.transform.position.x, transform.position.y, wayPoint.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, wayPointPos, speed * Time.deltaTime);
            }
            this.gameObject.transform.LookAt(wayPointPos);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Equals("Player"))
        {
            IsAround = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            IsAround = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player") && Input.GetKeyDown(KeyCode.E))
        {
            studentSaved = true;
            help.Stop();
            Light1.SetActive(true);
            Light2.SetActive(true);
        }
    }
}
