using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");

        direction = new Vector2(directionX, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }
}
