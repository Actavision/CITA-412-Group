using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    Rigidbody2D rb;
    public float speed = 6f; // speed of the enemy
    public float chaseRange = 20f; // range at which the enemy will start chasing the player
    public float attackRange = 1.5f; // range at which the enemy will attack the player
    public int damage = 10; // damage dealt by the enemy
    public float attackCooldown = 2f; // time between attacks
    Vector2 moveDirection;
    Transform player; // reference to the player's transform
    float lastAttackTime; // time when the enemy last attacked

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform; // find the player's transform
    }

    void Update()
    {
        // calculate the distance between the enemy and the player
        
        Vector3 direction = (player.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveDirection = direction;     
    }
    void FixedUpdate()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= chaseRange)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;

            // if the player is within the attack range and the attack cooldown has elapsed, attack them
            if (distanceToPlayer <= attackRange && Time.time >= lastAttackTime + attackCooldown)
            {
                //Attack();
                lastAttackTime = Time.time;
            }
        }
    }

    public void Die()
    {
       
    }

    // void Attack()
    //{
    // do damage to the player
    //    PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
    //playerHealth.TakeDamage(damage);
    // }
}

