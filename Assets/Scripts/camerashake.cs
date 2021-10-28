using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    //-Saga 
    public Vector2 amplitude;
    //Variabel för hur kraftigt den ska skaka
    public Vector2 frequency;
    //Hur mycket det skakar 
    public Vector2 time;
    //Hur lång tid skakningen tar 
    new Vector3 shakePos;
    new bool shouldShake;

    float shakeTime;
    
    void Update()
    {
        time += Time.time * frequency;
        shakePos.x = Mathf.Sin(time.x);

        shakePos = transform.localPosition;
        /*if(shakeTime > 0)
        {
           
        }*/


    }
}
