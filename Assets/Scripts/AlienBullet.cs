using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBullet : MonoBehaviour
{
    public float speed = 40f;  // En ripoff p� Mikhaels bullet kod med lite �ndringar - Andreas
    public int damage = 1;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
        Destroy(gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
