using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerExpandingSphere : MonoBehaviour
{
    public float growSpeed = 1f;

    public float maxSize = 3;
    public float minSize = 0.5f;
    public float targetSize = 1f;
    public CircleCollider2D circle;

    public LayerMask mask;

	// Use this for initialization
	void Start ()
	{
	    //if (targetSize < minSize)
	    {
	        targetSize = circle.radius;
	    }
	}
	
	// Update is called once per frame
	void Update ()
	{
	    var grow = Input.GetAxis("Vertical");
	    var size = targetSize + growSpeed * grow * Time.deltaTime;
	    circle.enabled = false;
	    if (Physics2D.OverlapCircle(this.transform.position, size, mask) == null)
	    {
	        targetSize = size;
	        targetSize = Mathf.Clamp(targetSize, minSize, maxSize);
	    }
	    circle.enabled = true;

	    circle.radius = Mathf.Lerp(circle.radius, targetSize, Time.deltaTime);
	}
}
