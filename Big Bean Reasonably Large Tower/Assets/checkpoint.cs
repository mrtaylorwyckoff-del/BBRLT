using UnityEngine;

public class checkpoint : MonoBehaviour
{
    GameController gameController;
    public Transform respawnPoint;
    private void Awake()
    {
        gameController= GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D collison)
    {
    
        if (collison.CompareTag("Player"))
        {
            Debug.Log("FGsgio");
            gameController.UpdateCheckpoint(respawnPoint.position);
        }


    }










}
