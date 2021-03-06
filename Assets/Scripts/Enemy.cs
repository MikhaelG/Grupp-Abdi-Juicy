using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhael
public class Enemy : MonoBehaviour
{
    public int health = 1; //enemy har 1hp - Andreas
    public int damage = 1;

    public GameObject deathEffect;
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0) //ifall hp ?r mindre ?n 0 s? d?r enemy - Andreas
        {
            Die();
        }

    }
  
    void Die ()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity); //Death effect spelas n?r enemy d?r -Andreas
        
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>(); //ifall player tar damage s? d?r man - Andraes
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
