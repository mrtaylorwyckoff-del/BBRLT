using System.Collections;   
using System.Collections.Generic;   
using UnityEngine;

public class objectdamage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerHealth playerHealth;
    public int damage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if(collision.gameObject.tag == "Player")
            {
                playerHealth.TakeDamage(1); 
            }
      
    }
}

