using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    // Sagas Kod, g�r s� att animationen fungerar
    
    public Animator animator;
    public TextFunction textFunction;
    public ButtonAnim buttonAnimator;
    public int thisIndex; //F�r att veta vilken knapp animationen ska �ppnas 

    void Update()
    {
        if(textFunction.index == thisIndex) //Om indexen �r just 
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
