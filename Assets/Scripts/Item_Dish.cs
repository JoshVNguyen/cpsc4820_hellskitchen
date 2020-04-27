using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Dish : Item
{
    private AudioSource soundEffect;

    void Start()
    {
        isPickedUp = false;
        isThrown = false;
        soundEffect = GetComponent<AudioSource> ();
        soundEffect.time = 0.5f;
    }

   void OnTriggerEnter(Collider other) {
        // If the item is being thrown and it collides with another player, reduce health
        if(other.gameObject.CompareTag("Enemy") && isThrown == true)
        {
            soundEffect.Play ();

            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(20);
            isThrown = false;

            Invoke("removeObject", 0.2f);
        }
        if(other.gameObject.CompareTag("Wall") && isThrown == true)
        {
            soundEffect.Play ();
            Invoke("removeObject", 0.2f);
        }
    }

    void removeObject() {
        Destroy(gameObject);
    }
}