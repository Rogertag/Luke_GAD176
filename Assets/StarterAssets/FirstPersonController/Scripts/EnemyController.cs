using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // this just pulls the AI packages from unity namespaces

public class EnemyController : MonoBehaviour
{

       public float lookRadius = 10f; // defining the radius for enemy to see player

       Transform target; // this will help us use AI in the unity engine through navmesh
       NavMeshAgent agent; // this is just using AI to read the map an navigate the terrain (pretty much a nextbot from gmod)
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>(); // this will get a GetComponent on a game object and apply that mapping to finding it 
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position); // move towards the target when in sight 

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position); // go after target please
        }
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius); // this is matching the spheres current position while drawing a sphere (kinda like a hitbox)
    }
}
