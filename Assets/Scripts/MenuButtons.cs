using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Sagas Kod, gör så att animationen fungerar
    
    public Animator animator;
    public TextFunction textFunction;
    public ButtonAnim buttonAnimator;
    public int thisIndex; //För att veta vilken knapp animationen ska öppnas 

    void Update()
    {
        if(textFunction.index == thisIndex) //Om indexen är just 
        {
            animator.SetBool("Maybe", true);
            if(Input.GetButtonDown("Submit")) //
            {
                animator.SetBool("Selected", true);
                animator.SetBool("Maybe", false);

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
}
