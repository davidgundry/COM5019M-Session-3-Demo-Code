using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float delta = Time.deltaTime * 10;
        transform.localScale += new Vector3(delta, delta,delta);
        transform.Rotate(new Vector3(0, Time.deltaTime * 10, 0));
        
        transform.Translate(new Vector3(0, 0, Time.deltaTime * 10));
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
        //collision.gameObject
        Destroy(gameObject);
    }
}
