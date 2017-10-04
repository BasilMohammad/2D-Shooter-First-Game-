using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float maxspeed = 10;
    bool facingright = true;
	// Update is called once per frame
	void fixedUpdate () {
        float move = Input.GetAxis("Horizontal");
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(move * maxspeed, GetComponent<Rigidbody2D>().velocity.y);


	}
}
