using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stuff getting called in update function for fire rate or anythign

/*
shooting script

 */
namespace Chapter1{
public class shoot : MonoBehaviour
{
    private float fireRate = 0.3f;
    private float nextFire;
    private RaycastHit hit;
    private float range = 300;
    private Transform myTransform;


    // Start is called before the first frame update
    void Start()
    {
        SetInitialReferences();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInput();
    }

    void SetInitialReferences(){
        myTransform = transform;
    }

    void CheckForInput()
    {
         if(Input.GetButton("Fire1")&& Time.time > nextFire)
      {
             Debug.DrawRay(transform.TransformPoint(0,0,1), myTransform.forward, Color.green, 3);
             if(Physics.Raycast(myTransform.TransformPoint(0,0,1),myTransform.forward,out hit,range))
             {
                if(hit.transform.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy" +hit.transform.name);
                }

                
                else
                {
                    Debug.Log("Not an enmy");
                }
             }
             nextFire = Time.time + fireRate;
        }        
     }   
   }
}

