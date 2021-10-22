using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAnim : Animations
{
    //Saga
    public Animator alienAnim;
    public GameObject alien;

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            alienAnim.SetBool("Explotion", true);

        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            alienAnim.SetBool("Explotion", false);
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            alienAnim.SetBool("Explotion", false);
            alienAnim.SetBool("Shoot", true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            alien.SetActive(true);
        }
    }
}
