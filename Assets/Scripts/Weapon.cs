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
            //Så att inte animationen fortsätter för evigt och slutar när man tar upp knappen -Saga
            playerAnim.SetBool("Shoot", false);
            print("Stop shooting");
        }
    }

    void Shoot ()
    {
        //Gör så att skjut animationen är på när den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
