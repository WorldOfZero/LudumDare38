using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPickupEffect : MonoBehaviour
{

    public Camera camera;
    public AnimationCurve animation;

    private Color defaultColor;
    public Color animationColor;

    private float timer;

	// Use this for initialization
	void Start ()
	{
	    defaultColor = camera.backgroundColor;
	    timer = animation[animation.length - 1].time;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timer += Time.deltaTime;
	    timer = Mathf.Min(timer, animation[animation.length - 1].time);

	    camera.backgroundColor = Color.Lerp(defaultColor, animationColor, animation.Evaluate(timer));
	}

    public void PlayAnimation()
    {
        timer = 0;
    }
}
