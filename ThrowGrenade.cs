using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
	public class ThrowGrenade : MonoBehaviour {

	public GameObject grenadePrefab;

	private Transform myTransform;

	public float propulsionForce = 30;

	// Use this for initialization
	void Start () {
		SetinitialReferences();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			SpawnGrenade();
		}
	}

	void SetinitialReferences()
	{
		myTransform = transform;
	}

	void SpawnGrenade()
	{
		GameObject go = (GameObject) Instantiate(grenadePrefab, myTransform.TransformPoint(0,0,0.5f),myTransform.rotation);
		go.GetComponent<Rigidbody>().AddForce(myTransform.forward*propulsionForce,ForceMode.Impulse);
		Destroy(go, 10);
	}
}

}

