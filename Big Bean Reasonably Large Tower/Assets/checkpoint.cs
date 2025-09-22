using UnityEngine;

public class checkpoint : MonoBehaviour
{
    GameController gameController;
    public Transform respawnPoint;
    private void Awake()
    {
        gameController= GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
    
        if (collison.CompareTag("Player"))
        {
            gameController.UpdateCheckpoint(respawnPoint.position);
        }


    }










}
