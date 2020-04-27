using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject [] spawners;
    public GameObject [] weapons;
    private int index;


    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 3.0f);
    }

    void Spawn()
    {
        // Randomly picking spawner 
        index = Random.Range (0, spawners.Length);
        Vector3 spawnLocation = spawners[index].transform.position;
        spawnLocation.y += 2;

        // Randomly picking weapon
        index = Random.Range (0, weapons.Length);


        // Checking if any other weapon is already there
        Collider [] spawnColliders = Physics.OverlapSphere(spawnLocation, 0.5f);

        if(spawnColliders.Length <= 0) {
            Instantiate(weapons[index], spawnLocation, Quaternion.identity);
        }

    }
}
