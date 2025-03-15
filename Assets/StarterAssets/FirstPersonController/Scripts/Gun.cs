using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
   
   public Camera fpsCam;


    // Update is called once per frame
    
    void Update ()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        RaycastHit hit; // caluclating the hit info for the ray cast
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name); 

            Enemy enemy = hit.transform.GetComponent<Enemy>();// to acsess the damage script making them interact
            if (enemy != null) // only delete enemy from scene
            {
                enemy.TakeDamage(damage); 
            }
        }
    }
}
