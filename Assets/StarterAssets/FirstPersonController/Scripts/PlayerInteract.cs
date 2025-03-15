using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam; // making to camera private will allow the raycasting to work
    [SerializeField] // this will make the private varibles viewable in unity
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
   
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<PlayerInteract>().cam;
    }

    // Update is called once per frame
    void Update()
    {
        // creates a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward); // this ray will shoot a infinte distance
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo; // varible to store our collision information.
        if (Physics.Raycast(ray, out hitInfo,distance,mask))
        {
           if (hitInfo.collider.GetComponent<Interactable>() != null)
           {
             Debug.Log(hitInfo.collider.GetComponent<Interactable>().promptMessage);
           }
        }
    }
}
