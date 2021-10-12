using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextFunction : MonoBehaviour
{
    public bool keyDown;
    [SerializeField]
    public int index;
    [SerializeField]
    public int maxIndex = 2;
    public Button[] button;
    void Start()
    {

    }
    void Update()
    {
        /*print(index);
        //Om vertikal inte är 0,om knappen är nedtryckt (om boolen är sann), om vertical är större än 0, om index är mindre än maxindex
        //Då ska de ta o plusa på index. Annars ska den sättas till 0 - Saga
        if (Input.GetAxis("Vertical") != 0)
        {
            if (!keyDown)
            {
                if (Input.GetAxis("Vertical") < 0)
                {
                    if (index < maxIndex)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }

                    keyDown = true;

                }
                else if (Input.GetAxis("Vertical") > 0)
                {
                    //Annars om vertical är större än 0
                    if (index < 0)
                    {
                        index--;
                    }
                    else
                    {
                        maxIndex = index;
                    }


                }
                //Om vertical är 0, då ska keydown vara falsk
                else
                {
                    keyDown = false;
                }

            }


        }*/
    }

}
    




