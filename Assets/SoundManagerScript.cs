using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip shootSound, enemyShoot, bombSound; //de ljud som ska spelas - Mikhael
    static AudioSource audioSrc;

    void Start()
    {
        shootSound = Resources.Load<AudioClip>("shoot");  //referenser
        enemyShoot = Resources.Load<AudioClip>("enemy");
        bombSound = Resources.Load<AudioClip>("bomb");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "shoot":
                audioSrc.PlayOneShot(shootSound); //spela ljudet en gång när man skjuter - Mikhael
                break;

            case "enemy":
                audioSrc.PlayOneShot(enemyShoot); //spela ljudet en gång när enemy skjuter - Mikhael
                break;

            case "bomb":
                audioSrc.PlayOneShot(bombSound); //spela ljudet en gång när enemy skjuter - Mikhael
                break;
        }
    }
}
