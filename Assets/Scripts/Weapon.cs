using UnityEngine;
//Mikhaels kod
public class Weapon : MonoBehaviour
{
    public Transform firePoint1; //f�rsta empty som �r i unity
    public Transform firePoint2; // andra empty som �r i unity
    public Animator playerAnim; //Saga
    public Transform firePoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Fire1 som st�r f�r space i unity
        {
            Shoot();
        }else if (Input.GetButtonUp("Fire1"))
        {
            //S� att inte animationen forts�tter f�r evigt och slutar n�r man tar upp knappen -Saga
            playerAnim.SetBool("Shoot", false);
            print("Stop shooting");
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation); //om man skjuter s� kommer bullets b�de fr�n firepoint 1 och 2
        //Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        //G�r s� att skjut animationen �r p� n�r den skjuter objektet -Saga
        playerAnim.SetBool("Shoot", true);
    }
}
