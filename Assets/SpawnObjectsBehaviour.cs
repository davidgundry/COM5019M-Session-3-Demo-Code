using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsBehaviour : MonoBehaviour
{

    public GameObject thingToSpawn;
    // private float howManySecondsHavePassedSinceLastSpawn = 0;
    public float spawnRateInSeconds = 2;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnLoop");
    }

    // Update is called once per frame
    void Update()
    {
        // howManySecondsHavePassedSinceLastSpawn += Time.deltaTime;
        // if (howManySecondsHavePassedSinceLastSpawn > spawnRateInSeconds)
        // {
        //     Instantiate(thingToSpawn);
        //     howManySecondsHavePassedSinceLastSpawn = 0;
            
        // }
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            Instantiate(thingToSpawn);
            yield return new WaitForSeconds(spawnRateInSeconds);
        }
        
    }

}
