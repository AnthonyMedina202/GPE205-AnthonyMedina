using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour 
{
   public int damage = 20;

   private void OnTriggerEnter(Collider other) 
   {
      AIEnemyHealth UATankAI = other.GetComponent<AIEnemyHealth>();
      if (UATankAI != null)
      {
         UATankAI.TakeDamage(damage);
      }
   }
}