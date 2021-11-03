using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpAnim : MonoBehaviour
{
    //Skriv ner fr�n MenuButton koden och g�r animationer till knapparna-Saga

    public Animator opAnimator;
    public Animator contrOp;
    public OpFunction opFunction;
    public SoundManager soundManager;
    public float thisIndex; //S� att man kan v�lja mellan horisontell eller vertikal index (Titta OpFunction koden)

    private void Start()
    {
        opAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (opFunction.opIndex == thisIndex) //Om indexen �r just p� den "Knappen" ska den g�ra det h�r
        {
            opAnimator.SetBool("Maybe", true);

            if (Input.GetButtonDown("Submit")) //G�r s� att man kan trycka p� kanppen
            {
                if(gameObject.tag == "Back") //Ska bara f�r Controls och Back 
                {
                    opAnimator.SetBool("Maybe", false);
                    opAnimator.SetBool("Selected", true);
                    
                }
                else if (gameObject.tag == "Volume")
                {
                    soundManager.SliderOp();
                }
                else if(gameObject.tag == "Controls")
                {
                    opAnimator.SetBool("Maybe", false);
                    opAnimator.SetBool("Selected", true);
                    contrOp.SetBool("Selected", true);
                    contrOp.SetBool("Maybe", false);

                    print("Selected");
                }else
                {
                    opAnimator.SetBool("Selected", false);
                    opAnimator.SetBool("Maybe", true);
                }


            }
            
        }else
        {
            opAnimator.SetBool("Maybe", false);
        }
    }
}
