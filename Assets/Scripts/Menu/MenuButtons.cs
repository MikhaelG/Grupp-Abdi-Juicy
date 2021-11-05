using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

                if (gameObject.tag == "Start")
                {
                    SceneManager.LoadScene(1);

                }else if (gameObject.tag == "Options")//Om objektet man selectar heter options ska den sätta på optionsmenyn
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
        //Skriv kod för att stänga av 
    }

}
