using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCntrl : MonoBehaviour
{
    public float maxspeed = 10f;
    bool facingRight = true;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }


    // Update is called once per frame
    void FixedUpdate()
    {

            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed", Mathf.Abs(move));
            Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
            rb2d.velocity = new Vector2(move * maxspeed, 0.0f);
        
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();

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
