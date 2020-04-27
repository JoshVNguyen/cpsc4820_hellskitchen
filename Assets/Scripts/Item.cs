using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool isPickedUp;
    public bool isThrown;

    public void pickUpItem(){
        isPickedUp = true;
    }

    public void throwItem(){
        isThrown = true;
        isPickedUp = false;
    } 
}
