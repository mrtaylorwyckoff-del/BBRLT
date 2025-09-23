using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Vector2 startPos;

    // Add this method to fix CS1061
    public void UpdateCheckpoint(Vector3 checkpointPosition)
    {
        startPos = checkpointPosition;
    }

    private void Start()
    {
        startPos = transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    void Die()
    {
        Respawn();
    }
    void Respawn()
    {
        transform.position = startPos;
    }
}