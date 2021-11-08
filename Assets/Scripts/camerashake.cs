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

    public Animator bomb;
    public Animator player;

    float shakeTime;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            bomb.SetBool("Bomb", true);
        }else if (Input.GetKeyUp(KeyCode.B))
        {
            bomb.SetBool("Bomb", false);
        }

        
        if(bomb.GetBool("Bomb") == true)
        {
            Shake();
        }else if(player.GetBool("Shoot") == true)
        {
            //Shake();
        }else if(player.GetBool("Explo") == true)
        {
            Shake();
        }

    }
    public void Shake()
    {
        shakePos = transform.localPosition;
        time += Time.time * frequency;
        shakePos.x = Mathf.Sin(time.x) * amplitude.x;

        transform.localPosition = shakePos;
    }
}
