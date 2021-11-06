using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 1;
    public Animator death;
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            //Die();
            DeathAnimation(); //Jag gjorde en sak i animationen så att man kan se att skeppet exploderas. Det tog oss annars direkt till dötts scenen. -Saga
        }

    }

    public void DeathAnimation()
    {

        death.SetBool("Shoot", false);
        death.SetBool("Explo", true);
    }
    public void Die() //Kommer användas som en ping grejsimojs i animationen -Saga
    {
        Destroy(gameObject);
        SceneManager.LoadScene(2); //Ska skickas till döds scenen -Saga

    }
}
