using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Gun
{
     public float fireRate = 15f;

     private float nextTimeToFire = 0f;


    // Update is called once per frame
    void Update()
    {
         if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate; // this will divied our fire rate to be able to shoot in intervals
        }
    }
}
