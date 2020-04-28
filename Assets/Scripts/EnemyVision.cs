using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public StateController enemy;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("item") && this.enemy.ItemInventory == null)
        {
            if (other.GetComponent<Item>().isPickedUp == false && other.GetComponent<Item>().isThrown == false)
            {

                if (this.enemy.ItemFound == null)
                {
                    this.enemy.ItemFound = other.gameObject;
                }
                else
                {
                    Vector3 curr_distance = this.enemy.transform.position - this.enemy.ItemFound.transform.position;
                    Vector3 new_distance = this.enemy.transform.position - other.gameObject.transform.position;

                    if (new_distance.sqrMagnitude < curr_distance.sqrMagnitude)
                    {
                        this.enemy.ItemFound = other.gameObject;
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(this.enemy.ItemFound == other)
        {
            this.enemy.ItemFound = null;
        }
    }
}
