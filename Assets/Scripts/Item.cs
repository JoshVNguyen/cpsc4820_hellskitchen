using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isPickedUp;
    public bool isThrown;
    public GameObject lastOwner;

    public void pickUpItem(GameObject owner){
        isPickedUp = true;
        lastOwner = owner;
    }

    public void throwItem(){
        isThrown = true;
        isPickedUp = false;
    } 
}
