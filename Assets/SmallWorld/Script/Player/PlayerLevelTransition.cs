using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevelTransition : MonoBehaviour
{
    public float initialSize = 1000;
    public float speed;
    public Transform transition;

	// Use this for initialization
	void Start ()
	{
	    transition.localScale = Vector3.one * initialSize;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transition.localScale = Vector3.Lerp(transition.localScale, Vector3.zero, Time.deltaTime * speed);
	    if (transition.localScale.x < 1)
	    {
	        Destroy(transition.gameObject);
	        Destroy(this);
	    }
	}
}
