using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    //-Saga 
    public Vector2 amplitude;
    //Variabel f�r hur kraftigt den ska skaka
    public Vector2 frequency;
    //Hur mycket det skakar 
    public Vector2 time;
    //Hur l�ng tid skakningen tar 
    new Vector3 shakePos;
    new bool shouldShake;

    public Animator bomb;

    float shakeTime;
    
    void Update()
    {
        if(bomb.GetBool("Bomb") == true)
        {
            time += Time.time * frequency;
            shakePos.x = Mathf.Sin(time.x);

            shakePos = transform.localPosition;
            /*if(shakeTime > 0)
            {

            }*/
        }

    }
}
