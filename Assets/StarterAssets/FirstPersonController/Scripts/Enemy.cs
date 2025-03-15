using UnityEngine;

public class Enemy : MonoBehaviour
{
  public float health = 50f;

  public void TakeDamage (float amount) // what damage is required from the class
  {
    health -= amount; // this amount will be equal to damage to our gun
    if (health <= 0f)
    {
        Die();
    }
  }

  void Die()
  {
    Destroy(gameObject);
  }

}
