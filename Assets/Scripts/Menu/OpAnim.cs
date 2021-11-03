using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpAnim : MonoBehaviour
{
    //Skriv ner från MenuButton koden och gör animationer till knapparna-Saga

    public Animator opAnimator;
    public Animator contrOp;
    public OpFunction opFunction;
    public SoundManager soundManager;
    public float thisIndex; //Så att man kan välja mellan horisontell eller vertikal index (Titta OpFunction koden)

    private void Start()
    {
        opAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        if (opFunction.opIndex == thisIndex) //Om indexen är just på den "Knappen" ska den göra det här
        {
            opAnimator.SetBool("Maybe", true);

            if (Input.GetButtonDown("Submit")) //Gör så att man kan trycka på kanppen
            {
                if(gameObject.tag == "Back") //Ska bara för Controls och Back 
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
