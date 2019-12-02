using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    //private bool facingLeft = true;
    private Animator anim;
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
       
        horizontal = Input.GetAxisRaw("Horizontal"); 
        vertical = Input.GetAxisRaw("Vertical"); 
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        /*
        if (horizontal < 0 && !facingLeft)
            reverseImage();
        else if (horizontal > 0 && facingLeft)
            reverseImage();
    }
 
	void reverseImage()
	{
		// Switch the value of the Boolean
		facingLeft = !facingLeft;
 
		// Get and store the local scale of the RigidBody2D
		Vector2 theScale = body.transform.localScale;
 
		// Flip it around the other way
		theScale.x *= -1;
		body.transform.localScale = theScale;
        */
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Teleport")
        {
            transform.position = col.transform.GetChild(0).position;
        }
    }
}


