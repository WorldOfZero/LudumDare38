using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionAntiGravity : MonoBehaviour
{

    public Transform sphereCenter;
    public Rigidbody2D rigidbody;
    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        rigidbody.AddForce((rigidbody.transform.position - sphereCenter.position).normalized * speed * Time.deltaTime);
	}
}
