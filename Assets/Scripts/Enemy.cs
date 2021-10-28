using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhaels kod
public class Enemy : MonoBehaviour
{
    public int health = 1; //enemy har 1hp

    public GameObject deathEffect;
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0) //ifall hp �r mindre �n 0 s� d�r enemy
        {
            Die();
        }

    }
  
    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity); //Death effect spelas n�r enemy d�r
        
        Destroy(gameObject);
    }
}
