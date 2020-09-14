using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHero : MonoBehaviour
{
    //Move
    public float speedMove;
    public float speedJump;
    private float moveInput;
    //Flip
    private bool facingRight=true;
    //Jump
    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGrounded;
    private int extraJump;
    public int extraJumpValue;
    //
    private Rigidbody2D rb;
    public Joystick joystick;
    void Start()
    {
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGrounded);
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speedMove, rb.velocity.y);
        if (facingRight == false && moveInput > 0) Flip();
        else if (facingRight == true && moveInput < 0) Flip();
    }

    private void Update()
    {
        float verticalMove = joystick.Vertical;
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
        }
        if (verticalMove >= 0.5f && extraJump > 0)
        {
            rb.velocity = Vector2.up * speedJump;
            extraJump--;
        }
        else if (verticalMove >= 0.8f && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * speedJump;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
}
