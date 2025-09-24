using UnityEngine;

public class RiseObject : MonoBehaviour
{
    public float riseSpeed = 1f; // Speed at which the object rises
    private object collision;
    public PlayerHealth playerHealth;
    public int damageAmount = 1;

    void Update()
    {
        // Move the object upwards along the Y-axis
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
    }
         private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }

    }
}
