using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    public static int speed = 5;
    int clock = 999;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        for (int i = 0; i < clock; i++)  //Ökar en varibal som används som hastighet för att öka svårhetsgraden -Andreas
        {
            Count.speed++;
            yield return new WaitForSeconds(5);
            Count.speed++;

        }
    }
}
