using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhael
public class PowerUp : MonoBehaviour
{
    public Animator playerAnim;
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player")) //kollar efter så att player tag tar upp den och ingen annan
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {

        GameObject firepoint = new GameObject();
        firepoint.transform.parent = player.transform;
        firepoint.transform.localPosition = new Vector3(0.6f,0,0); //Stället en ny firepoint ska spawnas vid
        firepoint.name = "Ny firepoint"; //namnet
        firepoint.transform.rotation = Quaternion.Euler (new Vector3(0, 0, 90)); //Firepoint behöver roteras så att den skjuter uppåt

        GameObject firepoint2 = new GameObject();
        firepoint2.transform.parent = player.transform;
        firepoint2.transform.localPosition = new Vector3(-0.6f, 0, 0);
        firepoint2.name = "Ny firepoint";
        firepoint2.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));

        Destroy(gameObject);

        //Lägger till en effekt/animationgrej till när den plockas upp-Saga
        playerAnim.SetBool("PowerUp", true);
        playerAnim.SetBool("Shoot", false);
        playerAnim.SetBool("Explo", false);
        
    }
}
