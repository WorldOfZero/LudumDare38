using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Rigidbody2D rigidbody;

    public Vector3 position1;
    public Vector3 position2;

    public float speed = 1;
    public bool direction = true;
    public float position;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    position += (direction ? speed : -speed) * Time.deltaTime;
	    if (direction && position > 1)
	    {
	        position = 1;
	        direction = false;
	    } else if (!direction && position < 0)
	    {
	        position = 0;
	        direction = true;
	    }

	    rigidbody.MovePosition(Vector3.Lerp(position1, position2, position));
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(position1, 0.25f);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(position2, 0.25f);
    }
}
