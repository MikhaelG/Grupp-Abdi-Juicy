using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Player player;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //När man collidar med en enemy så tar man skada - Andreas
    {
        if(collision.gameObject.tag == "enemy")
        {
            print("Dead");
            player.TakeDamage(damage);
        }
    }
}
