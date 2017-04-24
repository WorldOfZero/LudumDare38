using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour {
    public Rigidbody2D rigidbody;
    
    public float speed = 1;
    private float rotation = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotation += (speed * Time.deltaTime) % 360.0f;
        rigidbody.MoveRotation(rotation);
    }
}
