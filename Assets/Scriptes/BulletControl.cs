using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {
    public float speed;
    public CharacterCntrl player;
    public GameObject BulletParticle;
    public GameObject Env;
    public GameObject Bullet;
    public GameObject Enemy;
	// Use this for initialization
	void Start () {
        player = FindObjectOfType<CharacterCntrl>();
        if (player.transform.localScale.x < 0)
        {
            speed = -speed;
            transform.localScale = new Vector3(-10f, 10f, 10f);
        }
            
        
        
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {

            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(BulletParticle, Bullet.transform.position, Bullet.transform.rotation);
        }
        if (other.tag == "Env")
        {
            Destroy(gameObject);
            Instantiate(BulletParticle, Bullet.transform.position, Bullet.transform.rotation);
        }
        
    }

}
