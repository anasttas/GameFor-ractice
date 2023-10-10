using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    static public float flexibilityIndex;

    // Start is called before the first frame update
    void Start()
    {
        
        agent.speed= flexibilityIndex;
    }

    private void Update()
    {
        agent.destination = target.position;
    }
}
