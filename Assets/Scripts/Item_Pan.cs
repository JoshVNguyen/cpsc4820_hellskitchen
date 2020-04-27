using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Pan : Item
{
    private AudioSource soundEffect;

    void Start()
    {
        isPickedUp = false;
        isThrown = false;
        soundEffect = GetComponent<AudioSource> ();
    }

    void OnTriggerEnter(Collider other) {
        // If the item is being thrown and it collides with another player, reduce health
        if(other.gameObject.CompareTag("Player") && isThrown == true && lastOwner != other.gameObject)
        {
            soundEffect.Play ();

            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(40);
            isThrown = false;
        }
        if(other.gameObject.CompareTag("Wall") && isThrown == true)
        {
            isThrown = false;
        }
    }
}