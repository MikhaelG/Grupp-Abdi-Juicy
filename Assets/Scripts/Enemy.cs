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

        if (health <= 0) //ifall hp är mindre än 0 så dör enemy
        {
            Die();
        }

    }
  
    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity); //Death effect spelas när enemy dör
        
        Destroy(gameObject);
    }
}
