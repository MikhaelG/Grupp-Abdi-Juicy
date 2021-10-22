using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    //För att se om alla animationer fungerar -Saga
    //
    /*public Animator playerAnim;*/
    public Animator cometAnim;
    public GameObject comet;

    public virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cometAnim.SetBool("Destroy", true);

        }else if (Input.GetKeyUp(KeyCode.E))
        {
            cometAnim.SetBool("Destroy", false);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            comet.SetActive(true);
        }
    }
}
