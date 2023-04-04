using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public Vector3 enterPos;
    public Vector3 exitPos;

    public float fallDamageThreshold = 10.0f;
    public float fallDamageMultiplier = 1.0f;

    private Rigidbody playerRigidbody;

    public float health = 100f;
    public GameObject Player;
    public Text healthText;
    public GameObject DeadMessage;
    public GameObject DeadImage;
    private bool DeadMsg;
    public AudioSource audioData;
    public AudioSource Breathing;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GameObject.Find("HealthText").GetComponent<Text>();

        playerRigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {

        healthText.text = "HP: " + health.ToString("F0");

        if (DeadMsg == true && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        if (health <= 0f)
        {
            DeadMessage.SetActive(true);
            DeadImage.SetActive(true);
            DeadMsg = true;
            health = 100f;
        }
        if (health < 30f)
        {
            Breathing = GetComponent<AudioSource>();
            Breathing.Play(0);
        }


    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Fire"))
        {
            health = health - 5f * Time.deltaTime;
            Debug.Log("You are on fire!");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
       /* if (collision.gameObject)
        {
            float impactForce = collision.impulse.magnitude;
            if (impactForce > fallDamageThreshold)
            {
                float fallDamage = (impactForce - fallDamageThreshold) * fallDamageMultiplier;
                health = health - fallDamage;
            }
        }*/
    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.tag.Equals("Fire"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
      /*  if (col.tag == "Floor")
        {
            print("enter");
            enterPos = transform.position;
            if (exitPos.y - enterPos.y > 2)
            {
                print("falling dmg");
                health = health - 2 * exitPos.y - enterPos.y;
            }
        }*/
        }
    private void OnTriggerExit(Collider other)
    {
        /*if(other.tag == "Floor")
        {
            print("exit");

            exitPos = transform.position;
        }*/
        if (other.tag.Equals("Fire"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Stop();
        }
    }
}