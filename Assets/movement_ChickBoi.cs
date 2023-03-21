using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_ChickBoi : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "ChickBoi";
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (Input.GetKeyDown(KeyCode.W) == true) {
            rb.velocity = Vector2.up * moveSpeed;
        }
        if(Input.GetKeyDown(KeyCode.A) == true) {
            rb.velocity = Vector2.left * moveSpeed;
        }
        if(Input.GetKeyDown(KeyCode.S) == true) {
            rb.velocity = Vector2.down * moveSpeed;
        }
        if(Input.GetKeyDown(KeyCode.D) == true) {
            rb.velocity = Vector2.right * moveSpeed;
        }
    }
}
