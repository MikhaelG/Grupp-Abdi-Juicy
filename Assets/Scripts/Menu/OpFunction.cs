using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpFunction : MonoBehaviour
{
    // Sagas kod till funktionen p� Options menyn
    public TextFunction textFunction; //Vill ta viss kod d�rifr�n som ljudet
    //Vertikalt
    public int opIndex;
    public int maxOpIndex;
    //Horisontellt
    public float indexHo; //gjorde den till float s� att man kan urskilja vertikal index (opIndex) med horisontell index 
    public float maxIndexHo;
    public bool active = false;
    public bool hori = false;

    public GameObject optionMenu;

    public void Update()
    {
       
        if (active)
        {
            float vert = Input.GetAxisRaw("Vertical");
            float vertHo = Input.GetAxisRaw("Horizontal"); //Titta l�ngre ner f�r kod

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
            
            if (Input.GetButtonDown("Submit")) //Om man tryckt ner den d� kan man v�lja mellan att anv�nda WASD eller arrows
            {
                
                //Om det �r gametagen Controls. (Man vill kunna v�lja vilka typer av knappar n�r man �r p� inst�llningen controls)
                if (gameObject.tag == "Controls")
                {
                    hori = true;
                    print("yes");
                    if (vert > 0.95f)
                    {
                        indexHo--;


                        if (indexHo > maxIndexHo)
                        {
                            indexHo = 0.1f; //F�r att urskilja de tv�
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
                    //Ett s�tt att v�lja mellan de tv� olika keyboard typerna

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
        //Den h�r delen fungerar inte
        print("back");
        active = false;
        textFunction.options = false;
        optionMenu.SetActive(false);

    }
}
