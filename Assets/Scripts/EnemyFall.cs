using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFall : MonoBehaviour
{
    public Rigidbody2D alien;
    
    void Start()
    {
        Destroy(gameObject, 10);
    }

    void Update()
    {
        alien.velocity = new Vector2(0, -Count.speed); //Alien rör sig neråt - Andreas
    }
}
