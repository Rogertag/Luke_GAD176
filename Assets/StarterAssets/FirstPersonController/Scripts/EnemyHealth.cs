using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour

    // Start is called before the first frame update
    
    {
        public int currentHealth = 20;
        public static bool isEnemyDead = false;

        public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        if (currentHealth <= 0 && isEnemyDead == false)// is the current enemy health 0? no? don't run it
        {
               Debug.Log("DEAD: " + currentHealth);
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
