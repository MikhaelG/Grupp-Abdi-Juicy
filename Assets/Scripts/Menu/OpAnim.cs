using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpAnim : MonoBehaviour
{
    //Skriv ner fr�n MenuButton koden och g�r animationer till knapparna-Saga

    public Animator opAnimator;
    public OpFunction opFunction;
    public float thisIndex; //S� att man kan v�lja mellan horisontell eller vertikal index (Titta OpFunction koden)
    void Update()
    {
        if (opFunction.opIndex == thisIndex) //Om indexen �r just p� den "Knappen" ska den g�ra det h�r
        {
            opAnimator.SetBool("Maybe", true);

            if (Input.GetButtonDown("Submit")) //G�r s� att man kan trycka p� kanppen
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
