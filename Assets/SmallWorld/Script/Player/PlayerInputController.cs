using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{

    public float horizontal;
    public bool jump;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    horizontal = Input.GetAxis("Horizontal");
	    jump = Input.GetButtonDown("Jump");
	}
}
