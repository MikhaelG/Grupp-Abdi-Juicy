using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 1;
    public GameObject player;
    public Animator death;
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }

    }

    public void Die()
    {
        //death.SetBool("Explotion", true);
        print("Död");
        Destroy(player.gameObject);
    }
}
