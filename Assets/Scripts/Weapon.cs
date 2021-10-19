using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Animator playerAnim; //Saga
    public Transform firePoint;
    public GameObject bulletPrefab;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }else if (Input.GetButtonUp("Fire1"))
        {
            //S� att inte animationen forts�tter f�r evigt och slutar n�r man tar upp knappen -Saga
            playerAnim.SetBool("Shoot", false);
            print("Stop shooting");
        }
    }

    void Shoot ()
    {
        //G�r s� att skjut animationen �r p� n�r den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
