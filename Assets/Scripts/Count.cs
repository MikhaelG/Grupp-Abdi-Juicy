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
        for (int i = 0; i < clock; i++)  //�kar en varibal som anv�nds som hastighet f�r att �ka sv�rhetsgraden -Andreas
        {
            Count.speed++;
            yield return new WaitForSeconds(5);
            Count.speed++;

        }
    }
}
