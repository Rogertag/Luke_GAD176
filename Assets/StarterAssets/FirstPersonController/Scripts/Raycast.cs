using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] LayerMask layermask;
   
    // Update is called once per frame
    void Update()
    {
       if(Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 20f, layermask ))// if the player is looking at target (hitinfo) say you hit them
       {
          Debug.Log("Hit Something"); // respond back that you hit the target
          Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.red);
       }
       else 
       {
          Debug.Log("Hit Nothing");
          Debug.DrawRay (transform.position, transform.TransformDirection (Vector3.forward) * hitinfo.distance, Color.green);
          // red for nothing and green for something 
       }
    }
}
