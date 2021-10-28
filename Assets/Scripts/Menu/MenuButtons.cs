using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Sagas Kod, g�r s� att animationen fungerar
    
    public Animator animator;
    public TextFunction textFunction;
    public int thisIndex; //F�r att veta vilken knapp animationen ska �ppnas 

    //F�r OptionsMenu
    public GameObject optionsMenu;
    public OpFunction opFunction;

    void Update()
    {
        if(textFunction.index == thisIndex) //Om indexen �r just p� den "Knappen" ska den g�ra det h�r
        {
            animator.SetBool("Maybe", true);
            if(Input.GetButtonDown("Submit")) //G�r s� att man kan trycka p� kanppen
            {
                animator.SetBool("Selected", true);
                animator.SetBool("Maybe", false);

                if(gameObject.tag == "Options")//Om objektet man selectar heter options ska den s�tta p� optionsmenyn
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
