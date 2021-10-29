using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip shootSound, enemyShoot; //de ljud som ska spelas - Mikhael
    static AudioSource audioSrc;

    void Start()
    {
        shootSound = Resources.Load<AudioClip>("shoot");  //referenser
        enemyShoot = Resources.Load<AudioClip>("enemy");
       
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "shoot":
                audioSrc.PlayOneShot(shootSound); //spela ljudet en g�ng n�r man skjuter - Mikhael
                break;

            case "enemy":
                audioSrc.PlayOneShot(shootSound); //spela ljudet en g�ng n�r enemy skjuter - Mikhael
                break;
        }
    }
}