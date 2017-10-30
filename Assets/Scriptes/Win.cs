using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
    public CharacterCntrl Player;
    // Use this for initialization
    // Use this for initialization
    void Start()
    {
        Player = FindObjectOfType<CharacterCntrl>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("YOU WIN !!" + transform.position);
            Player.enabled = false;

        }
    }
}
