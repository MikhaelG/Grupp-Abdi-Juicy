using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerashake : MonoBehaviour
{
    //-Saga /Tobias
    public Vector2 amplitude;
    //Variabel f�r hur kraftigt den ska skaka
    public Vector2 frequency;
    //Hur mycket det skakar 
    public Vector2 time;
    //Hur l�ng tid skakningen tar 
    new Vector3 shakePos;

    float shakeTime;
    
    void Start()
    {
        
    }

    public void Explotion()
    {
        shakePos.x = Mathf.Sin(time.x);
        //Skaka mer+ ( *amlitude.x ) g�r samma sak f�r y

    }//else shakePos = Vector3.zero g�r s� att den kommer tillbaka till dens orginala pos

    void Update()
    {
        shakePos = transform.localPosition;
        if(shakeTime > 0)
        {
           
        }


    }
}
