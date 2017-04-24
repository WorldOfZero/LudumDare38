using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncMousePosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	    newPosition.z = this.transform.position.z;
	    this.transform.position = newPosition;
	}
}
