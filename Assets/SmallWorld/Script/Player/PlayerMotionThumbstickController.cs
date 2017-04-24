using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotionThumbstickController : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rigidbody;
    public Transform sphere;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var delta = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
	    var input = delta - rigidbody.transform.position;
	    input.Normalize();
	    var movement = new Vector2(input.x, input.y);
	    //rigidbody.AddForce(movement * speed * Time.deltaTime);

	    var difference = (rigidbody.transform.position - sphere.position);
	    var cross = Vector3.Cross(difference.normalized, Vector3.forward);

	    var dot = Vector3.Dot(movement, cross);

	    rigidbody.AddForce((dot > 0 ? 1 : -1) * cross * speed * Time.deltaTime);
    }
}
