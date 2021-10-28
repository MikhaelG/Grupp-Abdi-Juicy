using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpFunction : MonoBehaviour
{
    // Sagas kod till funktionen på Options menyn
    public TextFunction textFunction; //Vill ta viss kod därifrån som ljudet
    //Vertikalt
    public int opIndex;
    public int maxOpIndex;
    //Horisontellt
    public int indexHo;
    public int maxIndexHo;
    
    public virtual void Options()
    {
        float vert = Input.GetAxisRaw("Vertical");
        float vertHo = Input.GetAxisRaw("Horizontal"); //Titta längre ner för kod

        if (Input.GetButtonDown("Vertical"))
        {
            if (vert > 0.95f)
            {
                opIndex--;


                if (opIndex > maxOpIndex)
                {
                    opIndex = 0;
                }
            }


            if (vert < -0.95f)
            {
                opIndex++;

                if (opIndex < 0)
                {
                    opIndex = maxOpIndex;
                }
            }

        }
        else if (Input.GetButtonDown("Horizontal"))
        {
            if (vert > 0.95f)
            {
                indexHo--;


                if (indexHo > maxIndexHo)
                {
                    indexHo = 0;
                }
            }


            if (vert < -0.95f)
            {
                indexHo++;

                if (indexHo < 0)
                {
                    indexHo = maxIndexHo;
                }
            }
        }
    }
}
