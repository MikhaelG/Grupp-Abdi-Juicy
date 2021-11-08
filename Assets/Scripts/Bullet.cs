using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhael
public class Bullet : MonoBehaviour
{
    public float speed = 40f; //hastighet och damage för bullet
    public int damage = 1;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2);                  //Ta sönder bullet om 2 sekunder
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();   //bullet kollar efter om den träffade enemy; gör damage
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);   //Tar sönder enemy efter att den träffade den
    }

}
