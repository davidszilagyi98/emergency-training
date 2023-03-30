using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public Vector3 enterPos;
    public Vector3 exitPos;

    public float health = 100f;
    public GameObject Player;
    public Text healthText;
    public GameObject DeadMessage;
    public GameObject DeadImage;
    private bool DeadMsg;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GameObject.Find("HealthText").GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {

        healthText.text = "Health: " + health.ToString("F0");

        if (DeadMsg == true && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }
        if (health <= 0f)
        {
            DeadMessage.SetActive(true);
            DeadImage.SetActive(true);
            DeadMsg = true;
            health = 100f;
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Fire"))
        {
            health = health - 10f * Time.deltaTime;
            Debug.Log("You are on fire!");

        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Floor")
        {
            print("enter");
            enterPos = transform.position;
            if(exitPos.y - enterPos.y > 2)
            {
                print("falling dmg");
                health = health - 2 * exitPos.y - enterPos.y;
            }
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "Floor")
        {
            print("exit");

            exitPos = transform.position;
        }
    }
}