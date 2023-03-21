using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_flat_movement : MonoBehaviour
{
    private float moveSpeed = 5;
    private Rigidbody2D rb;
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "player";
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }
}
