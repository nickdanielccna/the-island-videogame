using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
	
public class TriggerExample : MonoBehaviour {

	private WalkThroughWall walkThroughWallSript;

	void Start()
	{
		SetinitialReferences();
	}

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log(other.name + "has entered");
		walkThroughWallSript.SetLayerToNotSolid();
	}

	void OnTriggerExit(Collider ohter)
	{
		//Debug.Log(ohter.name + "has exited");
		walkThroughWallSript.SetLayerToDefualt();

	}
	

	void SetinitialReferences()
	{
		if(GameObject.Find("Wall")!= null)
		{
			walkThroughWallSript = GameObject.Find("Wall").GetComponent<WalkThroughWall>();
		}
		
	}

}

}
