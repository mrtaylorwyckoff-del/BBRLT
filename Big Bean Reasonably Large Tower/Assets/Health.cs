using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;  
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
