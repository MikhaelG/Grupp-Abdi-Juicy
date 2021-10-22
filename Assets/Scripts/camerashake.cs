using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    //-Saga /Tobias
    public Vector2 amplitude;
    //Variabel för hur kraftigt den ska skaka
    public Vector2 frequency;
    //Hur mycket det skakar 
    public Vector2 time;
    //Hur lång tid skakningen tar 
    new Vector3 shakePos;

    float shakeTime;
    
    void Start()
    {
        
    }

    public void Explotion()
    {
        shakePos.x = Mathf.Sin(time.x);
        //Skaka mer+ ( *amlitude.x ) gör samma sak för y

    }//else shakePos = Vector3.zero gör så att den kommer tillbaka till dens orginala pos

    void Update()
    {
        shakePos = transform.localPosition;
        if(shakeTime > 0)
        {
           
        }


    }
}
