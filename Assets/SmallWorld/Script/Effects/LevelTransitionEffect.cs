using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelTransitionEffect : MonoBehaviour
{
    public ParticleSystem particles;
    public UnityEvent TransitionComplete;
    public float transitionTime;

    private bool started = false;
    private float timer;

	// Use this for initialization
	void Start ()
	{
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (started)
	    {
	        timer -= Time.deltaTime;
	        if (timer < 0)
	        {
	            TransitionComplete.Invoke();
	            if (particles.particleCount == 0)
	            {
	                Destroy(this.gameObject);
	            }
	        }
	    }
	}

    public void Begin()
    {
        if (!started)
        {
            particles.Play();
            this.transform.parent = null;
            GameObject.DontDestroyOnLoad(this.gameObject);
            timer = transitionTime;
            started = true;
        }
    }
}
