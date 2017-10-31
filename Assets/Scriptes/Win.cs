using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {
    public CharacterCntrl Player;
    public GameObject WinParticle;
    public Text WinText;
    void Start()
    {
        Player = FindObjectOfType<CharacterCntrl>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            WinText.text = "You Win!";
            Debug.Log("YOU WIN !!" + transform.position);
            Player.enabled = false;
            Player.gameObject.SetActive(false);
            Instantiate(WinParticle, Player.transform.position, Player.transform.rotation);
        }
    }
}
