using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhostSwap : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public Transform playerGhost;

    public GameObject teleportEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Fire1"))
	    {
	        this.transform.position = playerGhost.position;
	        GameObject.Instantiate(teleportEffect, this.transform.position, Quaternion.identity);
	    }
	}
}
