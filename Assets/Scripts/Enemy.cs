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

        if (health <= 0) //ifall hp är mindre än 0 så dör enemy - Andreas
        {
            Die();
        }

    }
  
    void Die ()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity); //Death effect spelas när enemy dör -Andreas
        
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>(); //ifall player tar damage så dör man - Andraes
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
