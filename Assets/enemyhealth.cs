using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 3;
    private int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
    }

    // Custom method to apply damage to the enemy
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Check if the enemy has run out of health
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    // Custom method to handle enemy death
    void Die()
    {
        // Add code to handle enemy death, such as playing an animation or destroying the enemy GameObject
        Destroy(gameObject);
    }
}