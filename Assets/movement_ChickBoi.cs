using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_ChickBoi : MonoBehaviour
{
    private float moveSpeed = 5;
    private Rigidbody2D rb;
    private Vector2 movement;
    private bool facingRight;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "player";
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //returns  -1 or 1
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x == 1 && !facingRight)
        {
            FlipSprite();
        }

        if (movement.x == -1 && facingRight)
        {
            FlipSprite();
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

    void FlipSprite()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}
