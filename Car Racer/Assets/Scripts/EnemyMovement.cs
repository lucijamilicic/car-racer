using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform goal;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
        agent.SetDestination(goal.position); 
        agent.speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick(){

        agent.speed = speed;
        
	}

    
}
