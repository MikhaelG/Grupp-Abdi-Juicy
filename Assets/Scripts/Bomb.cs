using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Mikhael, andreas
public class Bomb : MonoBehaviour
{
    public int damage = 1;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")) //Fire1 som står för space i unity
        {
            Shoot();
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            SoundManagerScript.PlaySound("shoot");   //spela skjuta ljud - Mikhael
            print("Stop shooting");
        }

       
    }

    IEnumerator Boom()
    {
        for (int i = 0; i< 999; i++)
        {
            yield return new WaitForSeconds(1);
            Destroy(GameObject.FindWithTag("Enemy"));
        }
        
    }

    void Shoot()
    {
        StartCoroutine(Boom());
        SoundManagerScript.PlaySound("bomb");   //spela skjuta ljud - Mikhael

    }
}