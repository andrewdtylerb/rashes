using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathfinding : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDir;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Normalize the moveDir vector to ensure consistent speed
        moveDir.Normalize();

        // Move the enemy
        rb.MovePosition(rb.position + moveDir * moveSpeed * Time.fixedDeltaTime);
    }

    public void MoveTo(Vector2 targetPosition)
    {
        // Calculate the direction vector towards the target position
        moveDir = (targetPosition - (Vector2)transform.position).normalized;
    }
}