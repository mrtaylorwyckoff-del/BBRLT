using System.Collections;
using System.Collections.Generic;   
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;
    //private Vector3 startPos;
    private int lives = 3;
    GameController gameController;

    void Start()
    {
        health = maxHealth;


        gameController = GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
    }


    public void TakeDamage(int amount)
    {
        health -= amount;  
        if (health <= 0)
        {
            Die(gameObject);
        }
    }
    void Die(GameObject gameObject)
    {
        if (lives > 0)
        {
            lives--;
            health = maxHealth; // Reset health on respawn
        }
        else
        {
            // Handle game over logic here if needed
            SceneManager.LoadScene("GameOver");
        }
        Respawn();
    }
    void Respawn()
    {
        transform.position = new Vector3(46.3f, 59.37f, 0f);
    }

}
