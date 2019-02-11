using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 1f;
    public float JumpSpeed = 4f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        if (hor != 0 && isGrounded)
        {
            rb.velocity = new Vector2(hor * speed, 0);
            animator.SetInteger("PlayerWalk", 1);
            Debug.Log("walk");
        }
        else
        {
            animator.SetInteger("PlayerWalk", 0);
            Debug.Log("idle");
        }

        float jump = Input.GetAxis("Jump");
        if (jump != 0 && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D()
    {
        isGrounded = true;
    }

    void OnCollisionExit2D()
    {
        //isGrounded = false;
    }
}