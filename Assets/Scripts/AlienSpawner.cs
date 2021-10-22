using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public Rigidbody2D alien;
    public Transform spawner;
    public static int clock = 999;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Timer()
    {
        for (int i = 0; i < clock; i++)
        {
            Instantiate(alien, spawner.position, spawner.rotation);
            yield return new WaitForSeconds(2);

        }
    }

    IEnumerator Move()
    {

        for (int i = 0; i < clock; i++)
        {
            spawner.transform.position = new Vector3(Random.Range(7, -7), 5, 0);
            yield return new WaitForSeconds(1);
            
        }
    }
}
