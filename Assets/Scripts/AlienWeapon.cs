using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AlienWeapon : MonoBehaviour
{
    //public Animator playerAnim; //Saga
    public Transform firePoint;
    public GameObject bulletPrefab;
    private int clock = 999;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        for (int i = 0; i < clock; i++)
        {
            Shoot();
            yield return new WaitForSeconds(1);
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        SoundManagerScript.PlaySound("enemy");   //spela skjuta ljud - Mikhael
        //Gör så att skjut animationen är på när den skjuter objektet -Saga
        //playerAnim.SetBool("Shoot", true);
    }
}
