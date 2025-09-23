using System.Collections;   
using System.Collections.Generic;   
using UnityEngine;


public class objectdamage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerHealth playerHealth;
    public int damage = 1;
    private string endCause;

    void Start()
    {
        if (playerHealth == null)
        {
            playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }

    }
<<<<<<< HEAD
    public void SwapCurrentScene(string name, string cause)
    {
        endCause = cause;
        SceneManager.LoadScene(name);
    }
   
=======

>>>>>>> 1f46dc7c66b7a3327d885e0b6db8275273e94264
}

