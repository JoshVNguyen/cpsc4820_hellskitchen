using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
float throwForce = 50;
Vector3 objectPos;
float distance;
public GameObject cube;
public GameObject ball;
public Rigidbody rb;
private bool hitr = false;
private bool press = false;

  void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 // Update is called once per frame
 void Update () {
     if(Input.GetKeyDown(KeyCode.F) && press == false)
    {
         press = true;
    }
  
    if(hitr == true && press ==true)
    {
        ball.transform.position= new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
    }
    if (Input.GetKeyDown("space") && press == true && hitr == true)
        { 
            press = false;
            hitr = false;
            ball.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);
        }
 }


     void OnTriggerEnter(Collider other)
    {
        //turn the bol value to true when you hit one of the cubes
        if(other.gameObject.CompareTag("ball"))
        {
            hitr = true;
        }
        
    }
}
