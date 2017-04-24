using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGhostPositioner : MonoBehaviour
{

    public Transform sphere;
    public Transform player;

    public Sprite playerSprite;
    public Sprite ghostSprite;

    public float radius = 0.25f;
    public LayerMask mask;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ghostSprite.


	    var difference = player.position - sphere.position;
	    var targetPosition = sphere.position - difference * 0.9f;

	    if (Physics2D.OverlapCircle(targetPosition, radius, mask) == null)
	    {
	        this.transform.position = targetPosition;
	    }
	    else
	    {
	        this.transform.position = player.position;
	    }
	}
}
