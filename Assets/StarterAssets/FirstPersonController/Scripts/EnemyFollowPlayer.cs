using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour

{
    // Start is called before the first frame update
    
   public Transform target; //enemy following player
   public float moveSpeed = 5; //speed off enemy follow player 
   public float enemySpeed;

   [SerializeField] private float timer = 5;
  private float bulletTime;

  public GameObject enemyBullet;
  public Transform spawnPoint;


  void Update()
  {
 
    ShootAtPlayer(); // this will call the function saying, ok I'm going to shoot at you now

    void AddVectors()
    {
      transform.position += new Vector3(0, 0, 1);

    }
    
    

    Vector3 direction = target.transform.position - transform.position; // this makes it go to player from enemy

    transform.position += direction * moveSpeed * Time.deltaTime; // this follows player 

   
   


  } 
  void ShootAtPlayer()
  {
       bulletTime -= Time.deltaTime;

       if (bulletTime > 0) return;

       bulletTime = timer;

       GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject; // this is how will get bulleet from the spawn point
       Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
       Debug.Log("I make contact");
       bulletRig.AddForce(bulletRig.transform.forward * enemySpeed); // speed of bullet
       Destroy(bulletObj, 0.1f); // the speed at which a bullet will be destroyed

  }

} 