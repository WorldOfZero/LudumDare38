using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleColliderExternalGenerator : MonoBehaviour
{
    public float radius = 1;
    public int points = 32;

    public CircleCollider2D circle;

	// Use this for initialization
	void OnEnable ()
	{
	    var edge = this.gameObject.AddComponent<EdgeCollider2D>();
        Vector2[] edgePoints = new Vector2[points + 1];
	    for (int i = 0; i < edgePoints.Length; ++i)
	    {
	        edgePoints[i] = new Vector2(Mathf.Cos(2 * Mathf.PI * (i / (float) points)), Mathf.Sin(2 * Mathf.PI * (i / (float) points))) * radius;
	    }

	    edge.points = edgePoints;
	}

    void Update()
    {
        this.transform.localScale = Vector3.one * circle.radius;
    }
}
