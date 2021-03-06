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
    public int atStopIndex; //För att spara index numret 
    [SerializeField]
    public int maxIndex = 2;

    public bool options; //för att få index grejen att sluta

    public AudioSource buttonAudio;
    public AudioClip audioClip;
    
    public AudioSource menuAudio;
    public AudioClip menuAuClip;

    public OpFunction opFun;
    void Start()
    {
        buttonAudio.GetComponent<AudioSource>();
        menuAudio.GetComponent<AudioSource>();
    }

    void Update()
    {
        menuAudio.playOnAwake = audioClip;

        

        float vert = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Vertical") && options == false)
        {
            
            if (vert > 0.95f)
            {
                index--;

                buttonAudio.PlayOneShot(audioClip);

                if (index > maxIndex)
                {
                    index = 0;
                }
            }
           

            if (vert < -0.95f)
            {
                index++;
                buttonAudio.PlayOneShot(audioClip);
                if (index < 0)
                {
                    index = maxIndex;
                }
            }
            atStopIndex = index;
        }

    }

    public void StopIndex()
    {
        options = true;
        opFun.active = true; //Koden blir aktiv
        print(options);
        index = atStopIndex; 
    }

}
    




