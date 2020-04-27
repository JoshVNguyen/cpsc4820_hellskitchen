using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TEST_nav : MonoBehaviour
{

    public GameObject target_player;
    public List<Transform> waypoint_list;

    private NavMeshAgent nav_agent;
    private Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        this.nav_agent = this.GetComponent<NavMeshAgent>();
        this.destination = this.target_player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.destination = this.target_player.transform.position;
        this.nav_agent.destination = this.destination;
    }
}
