using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
	public Rigidbody2D rb;
	public float jump;
	public float jumpLeft = 0;
	public float jumpRight = 0;
	public float jumpForce = 0;
	public float gravityScale = 5;
	public float fallGravityScale = 15;

    void Start()
    {

    }

    void Update()
    {
	    if (rb.velocity.y > 0)
	    {
		    rb.gravityScale = gravityScale;
	    }
	    else
	    {
		    {
			    rb.gravityScale = fallGravityScale;
		    }
	    }
    }

    public void JumpLeft()
    {
	    rb.gravityScale = gravityScale;
        rb.velocity = new Vector2(-jumpLeft, jumpForce);
    }
    public void JumpRight()
    {
		rb.gravityScale = gravityScale;
		rb.velocity = new Vector2(jumpRight, jumpForce);
	}

}
