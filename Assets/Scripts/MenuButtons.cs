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
            /*if(Input.GetAxis ("Submit") == 1) //
            {
                animator.SetBool("Selected", true);

            }*/
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("Selected", true);
            }else if(animator.GetBool("Selected"))
            {
                animator.SetBool("Selected", false);
                buttonAnimator.disableOnce = true;
            }
        }
        else
        {
            animator.SetBool("Maybe", false);
        }
    }
}
