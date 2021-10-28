using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnim : MonoBehaviour
{
    public TextFunction menuController;
    public bool disableOnce;

    public virtual void SoundPlay(AudioClip audioClip)
    {
        if (!disableOnce) 
        {
            //menuController.menuAudio.PlayOneShot(audioClip);

        }else
        {
            disableOnce = false;
        }
    }
}
