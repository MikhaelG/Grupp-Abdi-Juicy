using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player")) //kollar efter så att player tag tar upp den och ingen annan
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation); //Animation för pickup



        Destroy(gameObject);
    }
}
