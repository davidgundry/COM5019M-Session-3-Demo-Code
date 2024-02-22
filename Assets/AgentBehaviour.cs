using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehaviour : MonoBehaviour
{
    NavMeshAgent nma;
    PickupBehaviour[] pickups;

    // Start is called before the first frame update
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
        pickups = FindObjectsByType<PickupBehaviour>(FindObjectsSortMode.None);

        Transform currentTarget = _CurrentTarget();
        if (currentTarget)
            nma.destination = currentTarget.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Transform _CurrentTarget() { 
        if (pickups.Length > 0)
            return pickups[0].transform; 
        return null;
    }

    void OnTriggerEnter(Collider c)
    {
        PickupBehaviour pickup = c.gameObject.GetComponent<PickupBehaviour>();
        pickup?.onPickUp.Invoke();
    }
}
