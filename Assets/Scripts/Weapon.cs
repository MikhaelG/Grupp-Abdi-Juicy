using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhaels kod
public class Weapon : MonoBehaviour
{
    public Transform firePoint1; //första empty som är i unity
    public Transform firePoint2; // andra empty som är i unity
    public Animator playerAnim; //Saga
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Fire1 som står för space i unity
        {
            Shoot();
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            //Så att inte animationen fortsätter för evigt och slutar när man tar upp knappen -Saga
            //playerAnim.SetBool("Shoot", false);
            SoundManagerScript.PlaySound("shoot");   //spela skjuta ljud - Mikhael
            print("Stop shooting");
        }

    }

    void Shoot()
    {
        foreach (Transform child in transform)
        {
            Instantiate(bulletPrefab, child.position, child.rotation); //om man skjuter så kommer bullets både från firepoint 1 och 2
        }
        
        //Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        //Gör så att skjut animationen är på när den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
    }
}
