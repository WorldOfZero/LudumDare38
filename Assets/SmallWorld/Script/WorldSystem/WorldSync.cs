using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WorldSync : MonoBehaviour
{


    public CircleCollider2D circle;
    public Material worldRendererMaterial;
	
	// Update is called once per frame
	void Update ()
	{
	    if (circle != null && worldRendererMaterial != null)
	    {
	        worldRendererMaterial.SetVector("_MaskPosition", circle.transform.position);
	        worldRendererMaterial.SetFloat("_MaskRadius", circle.radius);
	    }
	}
}
