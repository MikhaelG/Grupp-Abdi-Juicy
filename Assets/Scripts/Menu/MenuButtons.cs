using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Sagas Kod, gör så att animationen fungerar
    
    public Animator animator;
    public TextFunction textFunction;
    public int thisIndex; //För att veta vilken knapp animationen ska öppnas 

    //För OptionsMenu
    public GameObject optionsMenu;
    public OpFunction opFunction;

    void Update()
    {
        if(textFunction.index == thisIndex) //Om indexen är just på den "Knappen" ska den göra det här
        {
            animator.SetBool("Maybe", true);
            if(Input.GetButtonDown("Submit")) //Gör så att man kan trycka på kanppen
            {
                animator.SetBool("Selected", true);
                animator.SetBool("Maybe", false);

                if(gameObject.tag == "Options")//Om objektet man selectar heter options ska den sätta på optionsmenyn
                {
                    optionsMenu.SetActive(true);
                    opFunction.Options(); //Titta i OpFunction koden
                }

            }else
            {
                animator.SetBool("Selected", false);
                animator.SetBool("Maybe", true);
            }
        }
        else
        {
            animator.SetBool("Maybe", false);
        }
    }

    /*void Options()
    {
        print("Active"); //For now
        

    }*/
}
