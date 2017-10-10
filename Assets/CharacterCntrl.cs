using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCntrl : MonoBehaviour
{
    public float maxspeed = 10f;
    bool facingRight = true;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700f;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //checks constantly if we are on ground
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);


        float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", Mathf.Abs(move));
            Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(move * maxspeed, 0.0f);
        
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();

    }


    void Update()
    {
    if (grounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
          anim.SetBool("Ground", false);
          GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }  
    }


    void Flip()
    {
        //This is made because i want my character to got not only right, but left also.
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        //So what I am doing here is I am flipping the world if i go to the left 
        //This is helping me because i do not have a moving backwards sprite, meaning less animation!
    }

}
