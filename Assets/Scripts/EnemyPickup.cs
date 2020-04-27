using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPickup : MonoBehaviour
{
    public StateController enemy;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item"))
        {
            if (other.GetComponent<Item>().isPickedUp == false && other.GetComponent<Item>().isThrown == false)
            { 
                this.enemy.ItemTouched = other.gameObject;
            } 
        }
    }

    void OnTriggerExit(Collider other)
    {
        GameObject item = other.gameObject;

        if (item != null)
        {
            this.enemy.ItemTouched = null;
        }
    }
}
