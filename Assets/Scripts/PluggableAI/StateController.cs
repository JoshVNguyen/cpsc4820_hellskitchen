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


    public float throwForce = 1000; // Used when the player throws a held item
    public float carry_height = 2.5f;
    public float distance_goal = 10.0f;

    [HideInInspector] public NavMeshAgent nav_agent;
    [HideInInspector] public int next_waypoint;
    [HideInInspector] public GameObject ItemFound;
    [HideInInspector] public GameObject ItemTouched; // Item the player is currently touching
    [HideInInspector] public GameObject ItemInventory; // Item in the player's inventory
    [HideInInspector] public float state_time_elapsed;

    //private Vector3 destination;



    void Start()
    {
        this.ItemFound = null;
        this.ItemTouched = null;
        this.ItemInventory = null;
        this.nav_agent = this.GetComponent<NavMeshAgent>();
        //this.destination = this.player.transform.position;

        this.state_time_elapsed = 0.0f;
    }

    void Update()
    {
        if(this.ItemInventory != null)
        {
            this.ItemInventory.transform.position =
                new Vector3(this.transform.position.x,
                            this.transform.position.y + this.carry_height,
                            this.transform.position.z);
        }

        this.state_time_elapsed += Time.deltaTime;
        this.currentState.UpdateState(this);
    }


    public void ThrowItem()
    {
        Vector3 throwVec = transform.forward;
        this.ItemInventory.GetComponent<Rigidbody>().AddForce(throwVec * throwForce);

        // Calling the gameObject's script function throwItem
        this.ItemInventory.GetComponent<Item>().throwItem();

        // Emptying the player's inventory
        this.ItemFound = null;
        this.ItemTouched = null;
        this.ItemInventory = null;
    }

    public bool PickupItem()
    {
        if (ItemTouched != null)
        {
            this.ItemFound = null;
            this.ItemInventory = this.ItemTouched;
            this.ItemTouched = null;
            this.ItemInventory.GetComponent<Item>().pickUpItem(this.gameObject);
            return true;
        }
        else
        {
            return false;
        }
    }


    public void TransitionToState(State nextState)
    {
        if (nextState != this.remainState)
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