﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Used when the player throws a held item
    public float throwForce = 1000;

    // Item the player is currently touching
    public GameObject ItemTouched;

    // Item in the player's inventory
    public GameObject ItemInventory;

    void Start() {
        // rb = GetComponent<Rigidbody>();
        ItemTouched = null;
    }

    void Update () {
        // Picking up an item that the player is touching
        if (Input.GetKeyDown(KeyCode.F) && ItemTouched != null) {
            playerPickUpItem();
        }
  
        // Moving the picked up item with the player
        if ( ItemInventory != null) {
            ItemInventory.transform.position = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
        }

        // Throwing an item
        if ( Input.GetKeyDown("space") && ItemInventory != null) {
            playerThrowItem();
        }
    }

    void playerPickUpItem(){
        ItemInventory = ItemTouched;

        // Calling the gameObject's script function pickUpItem
        ItemInventory.GetComponent<Item>().pickUpItem(this.gameObject);
    }

    void playerThrowItem(){
        Vector3 throwVec = transform.forward;
        ItemInventory.GetComponent<Rigidbody>().AddForce(throwVec * throwForce);
            
        // Calling the gameObject's script function throwItem
        ItemInventory.GetComponent<Item>().throwItem();

        // Emptying the player's inventory
        ItemInventory = null;
    }

    // If the player touches an item
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("item"))
        {
            ItemTouched = other.gameObject;
        }
    }

    // If the player stop touching an item
    void OnTriggerExit(Collider other){
        GameObject item = other.gameObject;

        if(item != null){
            ItemTouched = null;
        }
    }
}