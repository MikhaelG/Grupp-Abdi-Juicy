using UnityEngine;

public class Weapon : MonoBehaviour
{
<<<<<<< HEAD
    public Transform firePoint1;
    public Transform firePoint2;
=======
    public Animator playerAnim; //Saga
    public Transform firePoint;
>>>>>>> 9c92ec55cde0fd183d2c2cfd1a7f1f5d511b75b1
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

    void Shoot()
    {
<<<<<<< HEAD
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
=======
        //Gör så att skjut animationen är på när den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
>>>>>>> 9c92ec55cde0fd183d2c2cfd1a7f1f5d511b75b1
    }
}
