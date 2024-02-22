using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupBehaviour : MonoBehaviour
{

    public readonly UnityEvent onPickUp = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 start = new Vector3(Random.value * -50, 1000, Random.value * 50);
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(start, new Vector3(0, -1, 0), out hit, Mathf.Infinity))
        {
            transform.position = hit.point;
        }

    }
}
