using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionController : MonoBehaviour
{
    public float speed;
    public float torque;
    public PlayerInputController input;
    public Rigidbody2D rigidbody;

    public Transform sphere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var difference = (rigidbody.transform.position - sphere.position);
	    var cross = Vector3.Cross(difference.normalized, Vector3.forward);

	    rigidbody.AddTorque(input.horizontal * torque * Time.deltaTime);
	    rigidbody.AddForce(input.horizontal * cross * speed * Time.deltaTime);
	}
}
