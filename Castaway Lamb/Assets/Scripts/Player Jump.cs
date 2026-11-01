using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movespeed;

    public RaycastHit2D hit;
    public float jumpForce;
    private bool jumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            float horizontal = Input.GetAxis("Horizontal");

        rb.AddForce(Vector2.right * horizontal * movespeed * Time.deltaTime);

        Jump();
    }

    private void Jump()
    {
        hit = Physics2D.CircleCast(rb.position, 0.25f, Vector2.down, 5f);

        if (hit.collider != null && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
            jumping = true;
            Invoke("ResetJumping", 0.5f);


        }
        if (jumping && Input.GetKey(KeyCode.Space))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }

    }

    private void ResetJumping()
    {
        jumping = false;
    }
}

   


