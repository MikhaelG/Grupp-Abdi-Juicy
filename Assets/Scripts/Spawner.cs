using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
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
            Instantiate(alien, spawner.position, spawner.rotation); // Spawnar alien på spawners position - Andreas
            yield return new WaitForSeconds(1);
            
        }
    }

    IEnumerator Move() //Ändrar position på spawnern - Andreas
    {

        for (int i = 0; i < clock; i++)
        {
            spawner.transform.position = new Vector3(Random.Range(20, -20), 25, 0);
            yield return new WaitForSeconds(1);
            spawner.transform.position = new Vector3(Random.Range(20, -20), 25, 0);
        }
    }
}
