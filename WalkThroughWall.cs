using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1 
{
	public class WalkThroughWall : MonoBehaviour {

	private Color myColor = new Color(0.5f, 1, 0.5f, 1);

	// Use this for initialization

	public void SetLayerToNotSolid()
	{
		gameObject.layer = LayerMask.NameToLayer("Not Solid");
		GetComponent<Renderer>().material.color = myColor;

	}

	public void SetLayerToDefualt()
	{
		gameObject.layer = LayerMask.NameToLayer("Default");
		GetComponent<Renderer>().material.color = Color.white;
	}
}
}


