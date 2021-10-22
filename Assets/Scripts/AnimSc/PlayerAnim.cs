using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : Animations
{
    public Animator playerAnim;
    public GameObject player;
    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerAnim.SetBool("Explotion", true);

        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            playerAnim.SetBool("Explotion", false);
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            playerAnim.SetBool("Explotion", false);
            playerAnim.SetBool("Shoot", true);
        }
    }
}
