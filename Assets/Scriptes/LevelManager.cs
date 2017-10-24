using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public GameObject currentCheckpoint;
    private CharacterCntrl player;
    public GameObject DeathParticle;
    public GameObject RespawnParticle;
    public float RespawnDelay;
    // Use this for initialization
    void Start () {
        player = FindObjectOfType<CharacterCntrl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }
    IEnumerator RespawnPlayerCo()
    {
        Instantiate(DeathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.gameObject.SetActive(false);
        GetComponent<Renderer>().enabled = false;
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(RespawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.gameObject.SetActive(true);
        GetComponent<Renderer>().enabled = true;
        Instantiate(RespawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
}
