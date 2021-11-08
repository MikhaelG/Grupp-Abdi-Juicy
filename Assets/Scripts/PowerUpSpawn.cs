using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        powerUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        for(int i = 0; i < 999; i++)
        {
            yield return new WaitForSeconds(5);
            powerUp.SetActive(true);
        }
    }
}
