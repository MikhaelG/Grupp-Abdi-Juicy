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
        float vert = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Vertical"))
        {
            if (vert > 0.95f)
            {
                index--;
                if (index > maxIndex)
                {
                    index = 0;
                }
            }
           

            if (vert < -0.95f)
            {
                index++;
                if (index < 0)
                {
                    index = maxIndex;
                }
            }
        }

    }

}
    




