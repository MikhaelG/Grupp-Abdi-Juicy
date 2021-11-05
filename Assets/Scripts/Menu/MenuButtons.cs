using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

                if (gameObject.tag == "Start")
                {
                    SceneManager.LoadScene(1);

                }else if (gameObject.tag == "Options")//Om objektet man selectar heter options ska den s�tta p� optionsmenyn
                {
                    optionsMenu.SetActive(true);
                    textFunction.StopIndex();
                    opFunction.active = true; //Titta i OpFunction koden

                }else if (gameObject.tag == "Quit")
                {
                    Quit();

                }

            }
            else
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

    public virtual void Quit()
    {
        //Skriv kod f�r att st�nga av 
    }

}
