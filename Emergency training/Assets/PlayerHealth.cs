using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public GameObject Player;
    public Text healthText;
    public GameObject DeadMessage;
    private bool DeadMsg;
    // Start is called before the first frame update
    void Start()
    {
        healthText = GameObject.Find("HealthText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health.ToString("F1");

        if (DeadMsg == true && Input.GetKey(KeyCode.Space))
        {
            DeadMessage.SetActive(false);

        }
    }
}
