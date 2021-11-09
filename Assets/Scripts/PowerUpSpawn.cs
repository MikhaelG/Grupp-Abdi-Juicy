using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject powerUp;
    
    void Start()
    {
        StartCoroutine(Timer());
        powerUp.SetActive(false);
    }

    void Update()
    {
        
    }

    IEnumerator Timer() //Power Up kommer fram efter en viss tid, jag gjorde den inte slupmässig för att spelet skulle vara tävlingsinriktat. -Andreas
    {
        for(int i = 0; i < 999; i++)
        {
            yield return new WaitForSeconds(5);
            powerUp.SetActive(true);
        }
    }
}
