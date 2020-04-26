using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject weaponPrefab;
    public GameObject [] spawners;
    private int index;


    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 5.0f);
    }

    void Spawn()
    {
        index = Random.Range (0, spawners.Length);
        Vector3 spawnLocation = spawners[index].transform.position;
        spawnLocation.y += 10;

        Instantiate(weaponPrefab, spawnLocation, Quaternion.identity);
    }
}
