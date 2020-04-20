using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isPickedUp;
    public bool isThrown;

    void Start()
    {
        isPickedUp = false;
        isThrown = false;
    }

    public void pickUpItem(){
        isPickedUp = true;
    }

    public void throwItem(){
        isThrown = true;
        isPickedUp = false;
    } 

    void OnTriggerEnter(Collider other) {
        // If the item is being thrown and it collides with another player, reduce health
        if(other.gameObject.CompareTag("Player") && isThrown == true)
        {
            Debug.Log("OUCH");
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(20);
            isThrown = false;
        }
    }
}
