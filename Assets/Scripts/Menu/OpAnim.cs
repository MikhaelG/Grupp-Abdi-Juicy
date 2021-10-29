using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpAnim : MonoBehaviour
{
    //Skriv ner från MenuButton koden och gör animationer till knapparna-Saga

    public Animator opAnimator;
    public OpFunction opFunction;
    public float thisIndex; //Så att man kan välja mellan horisontell eller vertikal index (Titta OpFunction koden)
    void Update()
    {
        if (opFunction.opIndex == thisIndex) //Om indexen är just på den "Knappen" ska den göra det här
        {
            opAnimator.SetBool("Maybe", true);

            if (Input.GetButtonDown("Submit")) //Gör så att man kan trycka på kanppen
            {
                opAnimator.SetBool("Maybe", false);
                opAnimator.SetBool("Selected", false);

            }
            else
            {
                opAnimator.SetBool("Selected", false);
                opAnimator.SetBool("Maybe", true);
            }
        }else
        {
            opAnimator.SetBool("Maybe", false);
        }
    }
}
