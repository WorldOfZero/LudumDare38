using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonLauncher : MonoBehaviour
{
    public float force;
    public Animator controller;

    private float disabled;

    public void Update()
    {
        disabled -= Time.deltaTime;
    }

    public void Launch(Collider2D collider)
    {
        if (disabled <= 0)
        {

            controller.SetTrigger("Launch");
            collider.attachedRigidbody.AddForce(this.transform.up * force);
            disabled = 1;
        }
    }
}
