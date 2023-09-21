using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has an "enemyhealth" component
        enemyhealth enemyHealth = other.gameObject.GetComponent<enemyhealth>();

        if (enemyHealth != null)
        {
            // Apply damage to the enemy's health
            enemyHealth.TakeDamage(damageAmount);
        }
    }
}