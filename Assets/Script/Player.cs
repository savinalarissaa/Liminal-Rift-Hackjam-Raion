using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f;
    [SerializeField] private float _jumpForce = 5f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite; // for flipping character sprites
    private Animator anim;

    private bool onGround = true;
    private bool isJumping = false;
    //private bool running = false;
    private float moveDirection = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // Moving
        moveDirection = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveDirection * _moveSpeed, rb.velocity.y);

        // Animation
        if (moveDirection > 0)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if (moveDirection < 0)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        } 
        else if (moveDirection == 0)
        {
            anim.SetBool("running", false);
        }
            
        // Jumping
        if ((Input.GetKeyDown("w") || Input.GetButtonDown("Jump"))&& onGround)
        {
            Jump();
        }
        if (!onGround) StartCoroutine(FallDown());

        //Debug
        Debug.Log(onGround);
    }

    private void Jump()
    {
        //rb.AddForce(new Vector2(0f, _jumpForce));
        isJumping = true;
        anim.SetBool("jumping", true);
        rb.velocity = new Vector2(rb.velocity.x, _jumpForce);
        //StartCoroutine(FallDown());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
            isJumping = false;
            rb.gravityScale = 8f;
            anim.SetBool("jumping", false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = false;
        }
    }


    private IEnumerator FallDown()
    {
        float time = 0f, hoverDuration = 1.5f;
        Debug.Log(time);

        while (isJumping)
        {
            time += Time.deltaTime;
            Debug.Log(time);
            if (time >= hoverDuration) rb.gravityScale = 20f;
            yield return null;
        }
    }
}
