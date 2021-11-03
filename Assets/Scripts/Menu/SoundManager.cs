using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //Saga
    public Slider slider;
    public AudioSource audioSource;
    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }

    void SliderOp()
    {
        print("Music");
    }

}
