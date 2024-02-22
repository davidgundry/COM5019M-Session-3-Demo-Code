using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawneeBehaviour : MonoBehaviour
{

    PickupBehaviour target;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PickupBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.transform.position - transform.position;
        direction.Normalize();
        transform.Translate(Time.deltaTime * direction * speed, Space.World);
    }
}
