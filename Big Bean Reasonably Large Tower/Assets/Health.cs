using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Player Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Debug.Log("Player Died!");
        // Add death logic here (e.g., restart level, show game over screen)
    }
}
