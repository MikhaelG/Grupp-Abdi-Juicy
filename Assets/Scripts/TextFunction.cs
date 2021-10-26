using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextFunction : MonoBehaviour
{
    //Sagas kod
    public bool keyDown;
    [SerializeField]
    public int index;
    [SerializeField]
    public int maxIndex = 2;
    public Button button;
    public AudioSource menuAudio;

    void Start()
    {
        menuAudio.GetComponent<AudioSource>(); //Fixa soundeffects
    }

    void Update()
    {
        print(index);
        //Om vertikal inte är 0,om knappen är nedtryckt (om boolen är sann), om vertical är större än 0, om index är mindre än maxindex
        //Då ska de ta o plusa på index. Annars ska den sättas till 0 - Saga
        if (Input.GetAxis("Vertical") != 0)
        {
            if (!keyDown)
            {
                //Hoppar direkt till nummer 2 på index
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

                    keyDown = true;
                }
                //Om vertical är 0, då ska keydown vara falsk
                

            }else
            {
                keyDown = false;
            }

        }

        if(keyDown == true)
        {
            print("down");
        }
    }

}
    




