using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 40f;
    public int damage = 1;
    public Rigidbody2D rb;
    
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2);
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
