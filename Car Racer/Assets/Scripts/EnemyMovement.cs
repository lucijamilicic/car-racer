using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform goal;
    [SerializeField] NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(goal.position); 
        agent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
