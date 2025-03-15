using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacing : MonoBehaviour
{
    
    public Transform target; // this will follow and look at trhe target
    public float rotationalSpeed = 25f; // how fast should we be rotating?


    void Update()
    {
    //check angle
    RotationalSight();
    }

    void RotationalSight()
    {
        // grabing input from unity, this will be between -1 and 1 
        float rotationalInput = Input.GetAxis("Horizontal");
        float rotationInRadians = rotationalInput * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, rotationInRadians * rotationalSpeed);

    }
    
    
    
    
}
