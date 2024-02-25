using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    
    public class Detection : MonoBehaviour
   {

    private RaycastHit hit;
    public LayerMask detectionLayer;
    private float checkRate = 0.5f;
    private float nextCheck;
    private Transform myTransform;
    private float range = 5;




    // Start is called before the first frame update
    void Start()
    {
        SetInitialReferences();
    }

    // Update is called once per frame
    void Update()
    {
        DetectItems();
    }

    void SetInitialReferences()
    {
        myTransform = transform;
        detectionLayer = 1 << 9;
    }

    void DetectItems()
    {
        nextCheck = Time.time + checkRate;

        if(Physics.Raycast(myTransform.position,myTransform.forward, out hit,range,detectionLayer))
        {
            Debug.Log(hit.transform.name + "is an item");
        }
    }
  }

}
