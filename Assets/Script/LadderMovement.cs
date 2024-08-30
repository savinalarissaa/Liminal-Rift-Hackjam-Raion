using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    public float moveSpeed;
    
    private float vertical;
    private bool OnLadder;
    private bool IsClimbing;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        OnLadder = false;
    }

    private void Update()
    {
        vertical = Input.GetAxisRaw("Vertical"); //on a scale of -1 (down) to 1 (up)
        
        if (OnLadder && vertical > 0f)
        {
            IsClimbing = true;
        }

        //Debug.Log(OnLadder);
    }

    private void FixedUpdate()
    {
        if (IsClimbing)
        {
            rb.velocity = new Vector2(rb.velocity.x, vertical * moveSpeed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            OnLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            OnLadder = false;
            IsClimbing = false;
        }
    }
}
