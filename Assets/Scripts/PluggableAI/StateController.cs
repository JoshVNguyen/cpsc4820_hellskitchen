using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;

    public GameObject player;
    public List<Transform> waypoint_list;

    [HideInInspector] public NavMeshAgent nav_agent;
    [HideInInspector] public int next_waypoint;

    private Vector3 destination;
    private float state_time_elapsed;

    void Start()
    {
        this.nav_agent = this.GetComponent<NavMeshAgent>();
        this.destination = this.player.transform.position;

        this.state_time_elapsed = 0.0f;
    }

    void Update()
    {
        this.currentState.UpdateState(this);
    }

    public void TransitionToState(State nextState)
    {
        if(nextState != this.remainState)
        {
            this.currentState = nextState;
            this.OnExitState();
        }
    }

    private void OnExitState()
    {
        this.state_time_elapsed = 0.0f;
    }
}
