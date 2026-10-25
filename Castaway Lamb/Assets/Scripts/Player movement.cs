using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movespeed;
    public float maxVelocity = 1000f;
  

    public float jumpforce;
    private RaycastHit2D hit;
    private bool jumping;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumping = false;
    }
   void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rb.velocity = Vector2.right * horizontal * movespeed;

       // rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxVelocity);

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            if (rb.velocity.y == 0)
            {
                Vector2 newVelocity = new Vector2(rb.velocity.y, rb.velocity.y * 0.3f);
                rb.velocity = newVelocity;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

        
    }
   
    

}
    

    


