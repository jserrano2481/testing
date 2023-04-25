using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; 
    private NavMeshAgent agent; 

    void Start()
    {
        // Get a reference to the NavMeshAgent component
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Set the destination of the NavMeshAgent to the player's position
        agent.SetDestination(player.position);
        transform.LookAt(player.position);
    }
}
