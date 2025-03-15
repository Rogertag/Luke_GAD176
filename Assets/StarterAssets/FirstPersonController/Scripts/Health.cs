using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // eveertime the game is run it will reset the health 
    }

    void TakeDamage(int amount) // this can be used to take away the current health by 1
    {
         currentHealth -= amount;

         if(currentHealth <= 0)// if player reaches 0
         {
            // Player Dies
         }
    }
   
}
