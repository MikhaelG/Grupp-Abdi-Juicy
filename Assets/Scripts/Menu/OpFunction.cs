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
    public float indexHo; //gjorde den till float så att man kan urskilja vertikal index (opIndex) med horisontell index 
    public float maxIndexHo;
    public bool active = false;
    public bool hori = false;

    public GameObject optionMenu;

    public void Update()
    {
       
        if (active)
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
            
            if (Input.GetButtonDown("Submit")) //Om man tryckt ner den då kan man välja mellan att använda WASD eller arrows
            {
                
                //Om det är gametagen Controls. (Man vill kunna välja vilka typer av knappar när man är på inställningen controls)
                if (gameObject.tag == "Controls")
                {
                    hori = true;
                    print("yes");
                    if (vert > 0.95f)
                    {
                        indexHo--;


                        if (indexHo > maxIndexHo)
                        {
                            indexHo = 0.1f; //För att urskilja de två
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
                    //Ett sätt att välja mellan de två olika keyboard typerna

                }
                else if (gameObject.tag == "Back")
                {
                    Back();
                }

            }
        }

        
    }

    public void Back()
    {
        /*if (gameObject.tag == "Back")
        {
            
        }*/
        //Den här delen fungerar inte
        print("back");
        active = false;
        textFunction.options = false;
        optionMenu.SetActive(false);

    }
}
