using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint1;
    public Transform firePoint2;
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

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
        Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        //Gör så att skjut animationen är på när den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
    }
}
