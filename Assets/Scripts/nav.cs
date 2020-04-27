using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class nav : MonoBehaviour
{
    [SerializeField]
    bool partolWaiting;
    [SerializeField]
    float totalWaitTime = 3f;
    [SerializeField]
    float switchProbability = .2f;
    [SerializeField]
    List<GameObject> patrolPoints = new List<GameObject>();    
    
    NavMeshAgent navMeshAgent;
    int currentPatrolIndex;
    bool travelling;
    bool waiting;
    bool partolForward;
    float waitTimer;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();
        partolWaiting = false;
        
        if(patrolPoints != null && patrolPoints.Count >= 2)
        {
            currentPatrolIndex = 0;
            SetDestination();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(travelling && navMeshAgent.remainingDistance <= 1.0f)
        {
            travelling = false;
            if(partolWaiting)
            {
                waiting = true;
                waitTimer = 0f;
            }
            else
            {
                ChangePatrolPoint();
                SetDestination();
            }
        }

        if(waiting)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer >= totalWaitTime)
            {
                waiting = false;
                ChangePatrolPoint();
                SetDestination();
            }
        }
    }
    private void SetDestination()
    {
        if(patrolPoints != null)
        {
            Vector3 targetVector = patrolPoints[currentPatrolIndex].transform.position;
            navMeshAgent.SetDestination(targetVector);
            travelling = true;
        }
    }
    private void ChangePatrolPoint()
    {
        if(UnityEngine.Random.Range(0f,1f) <= switchProbability)
        {
            partolForward = !partolForward;
        }

        if(partolForward)
        {
            currentPatrolIndex = (currentPatrolIndex +1) %patrolPoints.Count;
        }
        else
        {
            if(--currentPatrolIndex < 0)
            {
                currentPatrolIndex = patrolPoints.Count -1;
            }
        }
    }
}

