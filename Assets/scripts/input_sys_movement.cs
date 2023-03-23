using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class input_sys_movement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D rb;
    private bool facingRight;
    private float moveSpeed;
    private Animator animator;
    private CapsuleCollider2D myCapsuleCollider;
    public popUpBoxScriptLinkedIn popUpBoxScriptLinkedIn;
    public bool isDialogOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
        facingRight = true;
        moveSpeed = 5;
        popUpBoxScriptLinkedIn.popUpAnimator.SetBool("isNormal", true);

    }

    // Update is called once per frame
    void Update()
    {
        //for flipping
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        if (moveInput.x == 1 && !facingRight)
        {
            FlipSprite();
            animator.SetBool("isRunning", true);
        }

        if (moveInput.x == -1 && facingRight)
        {
            FlipSprite();
            animator.SetBool("isRunning", true);
        }

        if (moveInput.x == 0 && moveInput.y == 0)
        {
            animator.SetBool("isRunning", false);
        }
    }

    void OnInteract(InputValue val)
    {

        Debug.Log("I am clicking space to interact");
        if (myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Interactables")))
        {
            Debug.Log("I am now interacting with interactables");

            if (!isDialogOpen) {
                popUpBoxScriptLinkedIn.openPopUp();
             
            }
            if (isDialogOpen) {
                popUpBoxScriptLinkedIn.closePopUp();
            }
           
        }

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (moveInput * moveSpeed * Time.fixedDeltaTime));

        if (moveInput.x == 0 && moveInput.y == 0)
        {
            animator.SetBool("isRunning", false);
        }
        else
        {
            animator.SetBool("isRunning", true);
        }
    }

    void FlipSprite()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }


}
